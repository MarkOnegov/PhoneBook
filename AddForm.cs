using System;
using System.Windows.Forms;

namespace PhoneBook
{
	public partial class AddForm : Form
	{
		public Note MyRecord;
		public AddForm(Note MyRecord)
		{
			InitializeComponent();
			this.MyRecord = MyRecord;
		}
		private void AddButton_Click(object sender, EventArgs e)
		{
			// определяем поля записи -
			// берем значения из соответствующих компонентов на форме
			MyRecord.LastName = LastNameTextBox.Text;
			MyRecord.Name = NameTextBox.Text;
			MyRecord.Patronymic = PatronymicTextBox.Text;
			MyRecord.Phone = PhoneMaskedTextBox.Text;
			MyRecord.Street = StreetTextBox.Text;
			MyRecord.House = (ushort)HouseNumericUpDown.Value;
			MyRecord.Flat = (ushort)FlatNumericUpDown.Value;
			DialogResult = DialogResult.OK;//Для того чтобы понимать, что закрыта по кнопке
			Close(); // закрываем форму
		}
	}
}
