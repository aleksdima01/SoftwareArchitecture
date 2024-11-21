namespace ClinicDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnUpdate = new Button();
            listViewClients = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderSureName = new ColumnHeader();
            columnHeaderFirsName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            addBtn = new Button();
            delBtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            documentText = new TextBox();
            textBox2 = new TextBox();
            patronymicText = new TextBox();
            sureNameText = new TextBox();
            nameText = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            docLbl = new Label();
            patronymicLbl = new Label();
            surNameLbl = new Label();
            nameLbl = new Label();
            birthdayPicker = new DateTimePicker();
            birthdayLbl = new Label();
            getOneBtn = new Button();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(33, 490);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 32);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderSureName, columnHeaderFirsName, columnHeaderPatronymic });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(33, 15);
            listViewClients.MultiSelect = false;
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(736, 370);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            listViewClients.SelectedIndexChanged += listViewClients_SelectedIndexChanged;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "#";
            // 
            // columnHeaderSureName
            // 
            columnHeaderSureName.Text = "Фамилия";
            columnHeaderSureName.Width = 200;
            // 
            // columnHeaderFirsName
            // 
            columnHeaderFirsName.Text = "Имя";
            columnHeaderFirsName.Width = 200;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Отчество";
            columnHeaderPatronymic.Width = 200;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(647, 414);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(122, 32);
            addBtn.TabIndex = 2;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(647, 490);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(122, 32);
            delBtn.TabIndex = 3;
            delBtn.Text = "Удалить";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // documentText
            // 
            documentText.Location = new Point(33, 414);
            documentText.Name = "documentText";
            documentText.Size = new Size(100, 23);
            documentText.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 452);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // patronymicText
            // 
            patronymicText.Location = new Point(351, 414);
            patronymicText.Name = "patronymicText";
            patronymicText.Size = new Size(100, 23);
            patronymicText.TabIndex = 7;
            // 
            // sureNameText
            // 
            sureNameText.Location = new Point(245, 414);
            sureNameText.Name = "sureNameText";
            sureNameText.Size = new Size(100, 23);
            sureNameText.TabIndex = 8;
            // 
            // nameText
            // 
            nameText.Location = new Point(139, 414);
            nameText.Name = "nameText";
            nameText.Size = new Size(100, 23);
            nameText.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(245, 452);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(351, 452);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 10;
            // 
            // docLbl
            // 
            docLbl.AutoSize = true;
            docLbl.Location = new Point(33, 391);
            docLbl.Name = "docLbl";
            docLbl.Size = new Size(61, 15);
            docLbl.TabIndex = 12;
            docLbl.Text = "Документ";
            docLbl.Click += label1_Click;
            // 
            // patronymicLbl
            // 
            patronymicLbl.AutoSize = true;
            patronymicLbl.Location = new Point(351, 391);
            patronymicLbl.Name = "patronymicLbl";
            patronymicLbl.Size = new Size(58, 15);
            patronymicLbl.TabIndex = 13;
            patronymicLbl.Text = "Отчество";
            // 
            // surNameLbl
            // 
            surNameLbl.AutoSize = true;
            surNameLbl.Location = new Point(245, 391);
            surNameLbl.Name = "surNameLbl";
            surNameLbl.Size = new Size(58, 15);
            surNameLbl.TabIndex = 14;
            surNameLbl.Text = "Фамилия";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(139, 391);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(31, 15);
            nameLbl.TabIndex = 15;
            nameLbl.Text = "Имя";
            nameLbl.Click += label3_Click;
            // 
            // birthdayPicker
            // 
            birthdayPicker.Location = new Point(457, 414);
            birthdayPicker.Name = "birthdayPicker";
            birthdayPicker.Size = new Size(167, 23);
            birthdayPicker.TabIndex = 16;
            // 
            // birthdayLbl
            // 
            birthdayLbl.AutoSize = true;
            birthdayLbl.Location = new Point(457, 391);
            birthdayLbl.Name = "birthdayLbl";
            birthdayLbl.Size = new Size(90, 15);
            birthdayLbl.TabIndex = 17;
            birthdayLbl.Text = "Дата рождения";
            // 
            // getOneBtn
            // 
            getOneBtn.Location = new Point(647, 452);
            getOneBtn.Name = "getOneBtn";
            getOneBtn.Size = new Size(122, 32);
            getOneBtn.TabIndex = 18;
            getOneBtn.Text = "Получить одного";
            getOneBtn.UseVisualStyleBackColor = true;
            getOneBtn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 545);
            Controls.Add(getOneBtn);
            Controls.Add(birthdayLbl);
            Controls.Add(birthdayPicker);
            Controls.Add(nameLbl);
            Controls.Add(surNameLbl);
            Controls.Add(patronymicLbl);
            Controls.Add(docLbl);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(nameText);
            Controls.Add(sureNameText);
            Controls.Add(patronymicText);
            Controls.Add(textBox2);
            Controls.Add(documentText);
            Controls.Add(delBtn);
            Controls.Add(addBtn);
            Controls.Add(listViewClients);
            Controls.Add(btnUpdate);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моя Клиника";
            // Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private ListView listViewClients;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSureName;
        private ColumnHeader columnHeaderFirsName;
        private ColumnHeader columnHeaderPatronymic;
        private Button addBtn;
        private Button delBtn;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox documentText;
        private TextBox textBox2;
        private TextBox patronymicText;
        private TextBox sureNameText;
        private TextBox nameText;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label docLbl;
        private Label patronymicLbl;
        private Label surNameLbl;
        private Label nameLbl;
        private DateTimePicker birthdayPicker;
        private Label birthdayLbl;
        private Button getOneBtn;
    }
}
