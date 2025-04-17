namespace VirtualEvents
{
    partial class AddChangeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title_lbl = new Label();
            title = new TextBox();
            category_lbl = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            description = new TextBox();
            label6 = new Label();
            participants = new TextBox();
            save_button = new Button();
            cancel_btn = new Button();
            datePicker = new DateTimePicker();
            comboBoxCategory_AddForm = new ComboBox();
            timePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title_lbl.Location = new Point(35, 25);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(102, 22);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Заголовок:";
            // 
            // title
            // 
            title.BorderStyle = BorderStyle.None;
            title.Location = new Point(170, 31);
            title.Margin = new Padding(3, 4, 3, 4);
            title.MaxLength = 35;
            title.Name = "title";
            title.Size = new Size(355, 20);
            title.TabIndex = 1;
            title.TextChanged += title_TextChanged;
            title.Validating += title_Validating;
            // 
            // category_lbl
            // 
            category_lbl.AutoSize = true;
            category_lbl.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            category_lbl.Location = new Point(36, 70);
            category_lbl.Name = "category_lbl";
            category_lbl.Size = new Size(102, 22);
            category_lbl.TabIndex = 2;
            category_lbl.Text = "Категория:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(36, 112);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 4;
            label3.Text = "Время:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(36, 155);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 7;
            label4.Text = "Дата:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(35, 208);
            label5.Name = "label5";
            label5.Size = new Size(98, 22);
            label5.TabIndex = 9;
            label5.Text = "Описание:";
            // 
            // description
            // 
            description.BorderStyle = BorderStyle.None;
            description.Location = new Point(170, 208);
            description.Margin = new Padding(3, 4, 3, 4);
            description.Multiline = true;
            description.Name = "description";
            description.RightToLeft = RightToLeft.No;
            description.ScrollBars = ScrollBars.Vertical;
            description.Size = new Size(601, 182);
            description.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(36, 404);
            label6.Name = "label6";
            label6.Size = new Size(103, 22);
            label6.TabIndex = 11;
            label6.Text = "Участники:";
            // 
            // participants
            // 
            participants.BorderStyle = BorderStyle.None;
            participants.Location = new Point(170, 404);
            participants.Margin = new Padding(3, 4, 3, 4);
            participants.MaxLength = 300;
            participants.Multiline = true;
            participants.Name = "participants";
            participants.RightToLeft = RightToLeft.No;
            participants.ScrollBars = ScrollBars.Vertical;
            participants.Size = new Size(601, 39);
            participants.TabIndex = 12;
            // 
            // save_button
            // 
            save_button.BackColor = Color.FromArgb(46, 166, 222);
            save_button.FlatStyle = FlatStyle.Popup;
            save_button.ForeColor = SystemColors.ButtonHighlight;
            save_button.Location = new Point(516, 464);
            save_button.Margin = new Padding(3, 4, 3, 4);
            save_button.Name = "save_button";
            save_button.Size = new Size(114, 34);
            save_button.TabIndex = 13;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.FromArgb(192, 0, 0);
            cancel_btn.FlatStyle = FlatStyle.Popup;
            cancel_btn.ForeColor = SystemColors.ButtonHighlight;
            cancel_btn.Location = new Point(657, 464);
            cancel_btn.Margin = new Padding(3, 4, 3, 4);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(114, 34);
            cancel_btn.TabIndex = 14;
            cancel_btn.Text = "Отменить";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(170, 155);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(355, 27);
            datePicker.TabIndex = 15;
            // 
            // comboBoxCategory_AddForm
            // 
            comboBoxCategory_AddForm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory_AddForm.FormattingEnabled = true;
            comboBoxCategory_AddForm.Items.AddRange(new object[] { "День рождения", "Косплей-вечеринка", "Маскарад", "Вечеринка для детей", "Выпускной" });
            comboBoxCategory_AddForm.Location = new Point(169, 69);
            comboBoxCategory_AddForm.Name = "comboBoxCategory_AddForm";
            comboBoxCategory_AddForm.Size = new Size(356, 28);
            comboBoxCategory_AddForm.TabIndex = 17;
            // 
            // timePicker
            // 
            timePicker.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(170, 112);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(355, 27);
            timePicker.TabIndex = 16;
            // 
            // AddChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(817, 544);
            Controls.Add(comboBoxCategory_AddForm);
            Controls.Add(timePicker);
            Controls.Add(datePicker);
            Controls.Add(cancel_btn);
            Controls.Add(save_button);
            Controls.Add(participants);
            Controls.Add(label6);
            Controls.Add(description);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(category_lbl);
            Controls.Add(title);
            Controls.Add(title_lbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddChangeForm";
            Text = "Event Creation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public System.Windows.Forms.Label title_lbl;
        public System.Windows.Forms.TextBox title;
        public System.Windows.Forms.Label category_lbl;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox description;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox participants;
        public System.Windows.Forms.Button save_button;
        public System.Windows.Forms.Button cancel_btn;
        public DateTimePicker datePicker;
        public DateTimePicker dateTimePicker1;
        public ComboBox comboBoxCategory_AddForm;
        public DateTimePicker timePicker;
    }
}