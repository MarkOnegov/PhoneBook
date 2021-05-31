using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace PhoneBook
{
	public partial class MainForm : Form
	{
		private List<Note> PhoneNote;
		private int current;
		private bool saved = true;
		private readonly string name = "Телефонный справочник";
		private bool Saved //Создаём getter и setter для поля Saved
		{ //get - отрабатывает при получении значения поля, set - отрабатывает при записи
			get => saved;//при считывании просто возвращаем значение переменной
			set//при записи
			{
				if (value)//если записываем что состаяние сохранено 
					Text = name;//оставляем название без изменений
				else//иначе
					Text = name + "*";//добавляем звёздочку к названиею
				saved = value;//записываем значение в переменную
			}
		}
		public MainForm()
		{
			PhoneNote = new List<Note>();
			current = -1;
			InitializeComponent();
		}
		private void PrintElement()
		{
			if ((current >= 0) && (current < PhoneNote.Count))
			{ // если есть что выводить
			  // MyRecord - запись списка PhoneNote номер current
				Note MyRecord = PhoneNote[current];
				// записываем в соответствующие элементы на форме
				// поля из записи MyRecord
				LastNameTextBox.Text = MyRecord.LastName;
				NameTextBox.Text = MyRecord.Name;
				PatronymicTextBox.Text = MyRecord.Patronymic;
				PhoneMaskedTextBox.Text = MyRecord.Phone;
				StreetTextBox.Text = MyRecord.Street;
				HouseNumericUpDown.Value = MyRecord.House;
				FlatNumericUpDown.Value = MyRecord.Flat;
			}
			else // если current равно -1, т. е. список пуст
			{ // очистить поля формы
				LastNameTextBox.Text = "";
				NameTextBox.Text = "";
				PatronymicTextBox.Text = "";
				PhoneMaskedTextBox.Text = "";
				StreetTextBox.Text = "";
				HouseNumericUpDown.Value = 1;
				FlatNumericUpDown.Value = 1;
			}
			// обновление строки состояния
			NumberToolStripStatusLabel.Text = (current + 1).ToString();
			QuantityToolStripStatusLabel.Text = PhoneNote.Count.ToString();
		}

		private void AddSubscriberToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// создаем запись - экземпляр класса Note
			Note MyRecord = new Note();
			// создаем экземпляр формы AddForm
			AddForm _AddForm = new AddForm(MyRecord);
			// открываем форму для добавления записи
			if (_AddForm.ShowDialog() != DialogResult.OK)
				return;
			// текущей записью становится последняя
			current = PhoneNote.Count;
			// добавляем к списку PhoneNote новый элемент - запись MyRecord,
			// взятую из формы AddForm
			if (!PhoneNote.Any(n => n == _AddForm.MyRecord))
				PhoneNote.Add(_AddForm.MyRecord);
			// выводим текущий элемент
			PrintElement();
			Saved = false;
		}
		private void PreviousButton_Click(object sender, EventArgs e)
		{
			if (current <= 0)//проверка на выход из диапазона
			{
				MessageBox.Show("Предыдущей записи не существует!", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);//выводим ошибку
				return;//и завершаем выполнение метода
			}
			current--; // уменьшаем номер текущей записи на 1
			PrintElement(); // выводим элемент с номером current
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			if (current >= PhoneNote.Count - 1)
			{
				MessageBox.Show("Следующей записи не существует!", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			current++;
			PrintElement();
		}
		private void SaveSubscriberToolStripMenuItem_Click(object sender, EventArgs e) =>
			Saved = SaveDialog();//при сохранении вызываем метод отвечающий за диалог сохранения

		private void LoadSubscriberToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Saved)//проверяем сохранены ли изменения
					SaveRequest();//если нет то спрашиваем, нужно ли их сохранить
				if (LoadSubscriberDialog.ShowDialog() != DialogResult.OK)
					return;//если запрос файла закрылся не по кнопке OK то завершаем выполнение метода
				if (LoadSubscriberDialog.FileName.ToLower().EndsWith(".xml"))//проверяем какой файл выбран
					PhoneNote = ReadXML(LoadSubscriberDialog.FileName);//и запускаем нужный обработчик
				else
					PhoneNote = ReadTXT(LoadSubscriberDialog.FileName);
				current = PhoneNote.Count > 0 ? 0 : -1;//Переходим к первой записи или выставляем -1 если ничего нет
				PrintElement();//Обновляем вывод
				Saved = true;//Т.к. мы только открыли файл, то изменений в нём нет
			}
			catch//Обрабатываем исключения
			{
				MessageBox.Show("Ошибка загрузки данных из файла", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void SaveRequest()//Запрос на сохранение
		{
			if (MessageBox.Show("Есть не сохранённые изменения.\nЖелаете сохранить их?",
				"Сохранить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Saved = SaveDialog();//Выводим диалоговое окно и при согласии сохраняем
		}
		private bool SaveDialog()//Сохранение файла
		{
			try
			{
				if (SaveSubscriberDialog.ShowDialog() != DialogResult.OK)
					return false;//Если не выбрали файл то возвращаем false
				if (SaveSubscriberDialog.FileName.ToLower().EndsWith(".xml"))//Проверяем расширение файла
					WriteXML(SaveSubscriberDialog.FileName);//и запускаем нужный обработчик
				else
					WriteTXT(SaveSubscriberDialog.FileName);
				return true;//После удачного сохранения возвращаем true
			}
			catch//Если произошла ошибка
			{
				MessageBox.Show("Ошибка записи данных в файл", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);//Сообщаем об этом
				return false;//и возвращаем false
			}
		}
		private void WriteTXT(string path)//Записи в текстовый файл
		{
			//получаем все поля для класса Note, которые являются публичными
			var fields = typeof(Note).GetFields().Where(f => f.IsPublic).ToList();
			using (StreamWriter sw = new StreamWriter(path))
				PhoneNote.ForEach(note =>//для всех записей из PhoneNote
				{
					fields.ForEach(//для каждого поля из класса Note
						t => sw.WriteLine("{0}:{1}", t.Name, t.GetValue(note)//записываем строку в файл в формате название_поля:значение
						)
					);
					sw.WriteLine('\t');//для удобства будем разделять записи строкой с табуляцией
				}
				);
		}
		private List<Note> ReadTXT(string path)
		{
			List<Note> notes = new List<Note>();//заводим переменную для хранения новых записей
			var fields = typeof(Note).GetFields().Where(f => f.IsPublic).ToList();
			using (StreamReader sr = new StreamReader(path))
			{
				var t = new Note();//создаём объект класса Note для хранения считанных данных
				while (!sr.EndOfStream)//считываем до конца файла
				{
					var s = sr.ReadLine();//считываем строку
					if (s.StartsWith("\t"))//если начинается с табуляции
					{
						if (!notes.Any(n => n == t))//Проверяем на дубликаты
							notes.Add(t);//если нет такого добавляем
						t = new Note();//создаём новый объект класса Note
						continue;//завершаем выполнение обработки данной строки
					}
					var d = s.IndexOf(':');//находим разделитель
					var name = s.Substring(0, d);//получаем название записанного поля
					var f = fields.Find(fld => fld.Name == name);//находим его среди полей Note
					if (f == null)//если нет такого
						continue;//обработавыем следущуюю строку
					var value = s.Substring(d + 1);//получаем значение поля из строки
					f.SetValue(t, Convert.ChangeType(value, f.FieldType));//Приводим считанного 
																		  //значение из строки 
																		  //к нужному типу и
																		  //записываем его
																		  //в наше поле
				}
			}
			return notes;
		}
		private void WriteXML(string path)
		{
			XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8);//Создаём writer для xml документов
			xmlTextWriter.WriteStartDocument();//Записываем заголовок
			xmlTextWriter.WriteStartElement("Notes");//Записываем корневой элемент
			xmlTextWriter.Close();//закрываем writer (закрывающий тег для корневого элемента будет добавлен автоматически)
			XmlDocument document = new XmlDocument();//создаём xml документ
			document.Load(path);//считваем его
			int i = 0;//переменная для хранения id
			PhoneNote.ForEach(note =>//для каждой записи
			{
				XmlElement element = document.CreateElement("Note");//создаём элемент
				document.DocumentElement.AppendChild(element);//добавляем его в xml документ
				XmlAttribute attribute = document.CreateAttribute("id");//создаём атрибут id
				attribute.Value = i.ToString();//устанавливаем ему атрибут id
				element.Attributes.Append(attribute);//добавляе атрибут к другим атрибутам elementa
				note.GetType().GetFields().Where(f => f.IsPublic)//для каждого публичного поля объета note
					.ToList().ForEach(f =>
					{
						var el = document.CreateElement(f.Name);//создаём элемент
						el.InnerText = f.GetValue(note).ToString();//куда записываем значение
						element.AppendChild(el);//и добавляем его к элементу Note
					});
				i++;//увеличиваем id
			});
			document.Save(path);//Сохраняем полученный xml документ
		}
		private List<Note> ReadXML(string path)
		{
			List<Note> notes = new List<Note>();
			XmlDocument document = new XmlDocument();
			document.Load(path);
			XmlElement root = document.DocumentElement;//Получаем корневой елемент
			if (root.Name != "Notes")//если его название не совпадает с наши
				throw new Exception();//выкидываем исключение
			var field = typeof(Note).GetFields().Where(f => f.IsPublic).ToList();
			foreach (XmlElement node in root)//для каждого дочернего елемента корневого элемента
			{
				if (node.Name != "Note")//Если не наш элемент пропускаем
					continue;
				Note t = new Note();//создаём переменную для хранения результата
				foreach (XmlNode chNode in node.ChildNodes)//Для каждого дочернего элемента элемента Note
				{
					var chNodeField = field.Find(f => f.Name == chNode.Name);//находим поле у класса Note
					if (chNodeField == null)//если нет пропускаем элемент
						continue;
					chNodeField.SetValue(t,//записываем значения приведя к нужному типу
						Convert.ChangeType(chNode.InnerText, chNodeField.FieldType));
				}
				if (!notes.Any(n => n == t))//Проверка на дубли
					notes.Add(t);
			}
			return notes;
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{//при закрытии
			if (!Saved)//проверям всё ли сохранено
				SaveRequest();//Ели нет то сохраняем
		}
	}
}