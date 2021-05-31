
namespace PhoneBook
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.LastNameTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.PatronymicTextBox = new System.Windows.Forms.TextBox();
			this.StreetTextBox = new System.Windows.Forms.TextBox();
			this.HouseNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.FlatNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.PreviousButton = new System.Windows.Forms.Button();
			this.NextButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.Quantity_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.QuantityToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.Number_ToolStripStatusLabe = new System.Windows.Forms.ToolStripStatusLabel();
			this.NumberToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.SubscriberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddSubscriberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveSubscriberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveSubscriberDialog = new System.Windows.Forms.SaveFileDialog();
			this.LoadSubscriberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadSubscriberDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).BeginInit();
			this.MainStatusStrip.SuspendLayout();
			this.MainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// LastNameTextBox
			// 
			this.LastNameTextBox.Enabled = false;
			this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LastNameTextBox.Location = new System.Drawing.Point(100, 27);
			this.LastNameTextBox.MaxLength = 25;
			this.LastNameTextBox.Name = "LastNameTextBox";
			this.LastNameTextBox.Size = new System.Drawing.Size(237, 26);
			this.LastNameTextBox.TabIndex = 0;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Enabled = false;
			this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameTextBox.Location = new System.Drawing.Point(100, 59);
			this.NameTextBox.MaxLength = 25;
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(237, 26);
			this.NameTextBox.TabIndex = 1;
			// 
			// PatronymicTextBox
			// 
			this.PatronymicTextBox.Enabled = false;
			this.PatronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PatronymicTextBox.Location = new System.Drawing.Point(100, 91);
			this.PatronymicTextBox.MaxLength = 25;
			this.PatronymicTextBox.Name = "PatronymicTextBox";
			this.PatronymicTextBox.Size = new System.Drawing.Size(237, 26);
			this.PatronymicTextBox.TabIndex = 2;
			// 
			// StreetTextBox
			// 
			this.StreetTextBox.Enabled = false;
			this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StreetTextBox.Location = new System.Drawing.Point(100, 123);
			this.StreetTextBox.MaxLength = 45;
			this.StreetTextBox.Name = "StreetTextBox";
			this.StreetTextBox.Size = new System.Drawing.Size(237, 26);
			this.StreetTextBox.TabIndex = 3;
			// 
			// HouseNumericUpDown
			// 
			this.HouseNumericUpDown.Enabled = false;
			this.HouseNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HouseNumericUpDown.Location = new System.Drawing.Point(100, 155);
			this.HouseNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.HouseNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.HouseNumericUpDown.Name = "HouseNumericUpDown";
			this.HouseNumericUpDown.Size = new System.Drawing.Size(237, 26);
			this.HouseNumericUpDown.TabIndex = 4;
			this.HouseNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// FlatNumericUpDown
			// 
			this.FlatNumericUpDown.Enabled = false;
			this.FlatNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FlatNumericUpDown.Location = new System.Drawing.Point(100, 187);
			this.FlatNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.FlatNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.FlatNumericUpDown.Name = "FlatNumericUpDown";
			this.FlatNumericUpDown.Size = new System.Drawing.Size(237, 26);
			this.FlatNumericUpDown.TabIndex = 5;
			this.FlatNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// PhoneMaskedTextBox
			// 
			this.PhoneMaskedTextBox.Enabled = false;
			this.PhoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PhoneMaskedTextBox.Location = new System.Drawing.Point(100, 219);
			this.PhoneMaskedTextBox.Mask = "(999) 000-0000";
			this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
			this.PhoneMaskedTextBox.Size = new System.Drawing.Size(237, 26);
			this.PhoneMaskedTextBox.TabIndex = 6;
			// 
			// PreviousButton
			// 
			this.PreviousButton.AutoSize = true;
			this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PreviousButton.Location = new System.Drawing.Point(100, 251);
			this.PreviousButton.Name = "PreviousButton";
			this.PreviousButton.Size = new System.Drawing.Size(75, 36);
			this.PreviousButton.TabIndex = 0;
			this.PreviousButton.Text = "<";
			this.PreviousButton.UseVisualStyleBackColor = true;
			this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
			// 
			// NextButton
			// 
			this.NextButton.AutoSize = true;
			this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NextButton.Location = new System.Drawing.Point(181, 251);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(75, 36);
			this.NextButton.TabIndex = 1;
			this.NextButton.Text = ">";
			this.NextButton.UseVisualStyleBackColor = true;
			this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Фамилия";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Отчество";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Улица";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Дом";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 189);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Квартира";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(12, 222);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "Телефон";
			// 
			// MainStatusStrip
			// 
			this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quantity_ToolStripStatusLabel,
            this.QuantityToolStripStatusLabel,
            this.Number_ToolStripStatusLabe,
            this.NumberToolStripStatusLabel});
			this.MainStatusStrip.Location = new System.Drawing.Point(0, 299);
			this.MainStatusStrip.Name = "MainStatusStrip";
			this.MainStatusStrip.Size = new System.Drawing.Size(349, 24);
			this.MainStatusStrip.TabIndex = 14;
			this.MainStatusStrip.Text = "statusStrip1";
			// 
			// Quantity_ToolStripStatusLabel
			// 
			this.Quantity_ToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.Quantity_ToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.Quantity_ToolStripStatusLabel.Name = "Quantity_ToolStripStatusLabel";
			this.Quantity_ToolStripStatusLabel.Size = new System.Drawing.Size(123, 19);
			this.Quantity_ToolStripStatusLabel.Text = "Количество записей";
			// 
			// QuantityToolStripStatusLabel
			// 
			this.QuantityToolStripStatusLabel.AutoSize = false;
			this.QuantityToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.QuantityToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.QuantityToolStripStatusLabel.Name = "QuantityToolStripStatusLabel";
			this.QuantityToolStripStatusLabel.Size = new System.Drawing.Size(30, 19);
			this.QuantityToolStripStatusLabel.Text = "0";
			// 
			// Number_ToolStripStatusLabe
			// 
			this.Number_ToolStripStatusLabe.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.Number_ToolStripStatusLabe.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.Number_ToolStripStatusLabe.Name = "Number_ToolStripStatusLabe";
			this.Number_ToolStripStatusLabe.Size = new System.Drawing.Size(90, 19);
			this.Number_ToolStripStatusLabe.Text = "Номер записи";
			// 
			// NumberToolStripStatusLabel
			// 
			this.NumberToolStripStatusLabel.AutoSize = false;
			this.NumberToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.NumberToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.NumberToolStripStatusLabel.Name = "NumberToolStripStatusLabel";
			this.NumberToolStripStatusLabel.Size = new System.Drawing.Size(30, 19);
			this.NumberToolStripStatusLabel.Text = "0";
			// 
			// MainMenuStrip
			// 
			this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubscriberToolStripMenuItem});
			this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip.Name = "MainMenuStrip";
			this.MainMenuStrip.Size = new System.Drawing.Size(349, 24);
			this.MainMenuStrip.TabIndex = 15;
			this.MainMenuStrip.Text = "menuStrip1";
			// 
			// SubscriberToolStripMenuItem
			// 
			this.SubscriberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSubscriberToolStripMenuItem,
            this.SaveSubscriberToolStripMenuItem,
            this.LoadSubscriberToolStripMenuItem});
			this.SubscriberToolStripMenuItem.Name = "SubscriberToolStripMenuItem";
			this.SubscriberToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.SubscriberToolStripMenuItem.Text = "Абонент";
			// 
			// AddSubscriberToolStripMenuItem
			// 
			this.AddSubscriberToolStripMenuItem.Name = "AddSubscriberToolStripMenuItem";
			this.AddSubscriberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.AddSubscriberToolStripMenuItem.Text = "Добавить";
			this.AddSubscriberToolStripMenuItem.Click += new System.EventHandler(this.AddSubscriberToolStripMenuItem_Click);
			// 
			// SaveSubscriberToolStripMenuItem
			// 
			this.SaveSubscriberToolStripMenuItem.Name = "SaveSubscriberToolStripMenuItem";
			this.SaveSubscriberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.SaveSubscriberToolStripMenuItem.Text = "Сохранить";
			this.SaveSubscriberToolStripMenuItem.Click += new System.EventHandler(this.SaveSubscriberToolStripMenuItem_Click);
			// 
			// SaveSubscriberDialog
			// 
			this.SaveSubscriberDialog.Filter = "XML files (.xml)|*.xml|Text files (.txt)|*.txt";
			// 
			// LoadSubscriberToolStripMenuItem
			// 
			this.LoadSubscriberToolStripMenuItem.Name = "LoadSubscriberToolStripMenuItem";
			this.LoadSubscriberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.LoadSubscriberToolStripMenuItem.Text = "Загрузить";
			this.LoadSubscriberToolStripMenuItem.Click += new System.EventHandler(this.LoadSubscriberToolStripMenuItem_Click);
			// 
			// LoadSubscriberDialog
			// 
			this.LoadSubscriberDialog.Filter = "XML files (.xml)|*.xml|Text files (.txt)|*.txt";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 323);
			this.Controls.Add(this.MainStatusStrip);
			this.Controls.Add(this.MainMenuStrip);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NextButton);
			this.Controls.Add(this.PreviousButton);
			this.Controls.Add(this.PhoneMaskedTextBox);
			this.Controls.Add(this.FlatNumericUpDown);
			this.Controls.Add(this.HouseNumericUpDown);
			this.Controls.Add(this.StreetTextBox);
			this.Controls.Add(this.PatronymicTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.LastNameTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
#pragma warning disable CS1717 // Проведено присвоение той же переменной; действительно выполнить такое назначение, а не иное?
			this.MainMenuStrip = this.MainMenuStrip;
#pragma warning restore CS1717 // Проведено присвоение той же переменной; действительно выполнить такое назначение, а не иное?
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Телефонный справочник";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).EndInit();
			this.MainStatusStrip.ResumeLayout(false);
			this.MainStatusStrip.PerformLayout();
			this.MainMenuStrip.ResumeLayout(false);
			this.MainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox LastNameTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox PatronymicTextBox;
		private System.Windows.Forms.TextBox StreetTextBox;
		private System.Windows.Forms.NumericUpDown HouseNumericUpDown;
		private System.Windows.Forms.NumericUpDown FlatNumericUpDown;
		private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
		private System.Windows.Forms.Button PreviousButton;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.StatusStrip MainStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel Quantity_ToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel QuantityToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel Number_ToolStripStatusLabe;
		private System.Windows.Forms.ToolStripStatusLabel NumberToolStripStatusLabel;
#pragma warning disable CS0108 // "MainForm.MainMenuStrip" скрывает наследуемый член "Form.MainMenuStrip". Если скрытие было намеренным, используйте ключевое слово new.
		private System.Windows.Forms.MenuStrip MainMenuStrip;
#pragma warning restore CS0108 // "MainForm.MainMenuStrip" скрывает наследуемый член "Form.MainMenuStrip". Если скрытие было намеренным, используйте ключевое слово new.
		private System.Windows.Forms.ToolStripMenuItem SubscriberToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddSubscriberToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveSubscriberToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog SaveSubscriberDialog;
		private System.Windows.Forms.ToolStripMenuItem LoadSubscriberToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog LoadSubscriberDialog;
	}
}

