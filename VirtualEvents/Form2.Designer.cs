namespace VirtualEvents
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            category = new TextBox();
            label3 = new Label();
            time = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            description = new TextBox();
            label6 = new Label();
            participants = new TextBox();
            save_button = new Button();
            cancel_btn = new Button();
            dateTimePicker = new DateTimePicker();
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
            title.Name = "title";
            title.Size = new Size(355, 20);
            title.TabIndex = 1;
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
            // category
            // 
            category.BorderStyle = BorderStyle.None;
            category.Location = new Point(170, 76);
            category.Margin = new Padding(3, 4, 3, 4);
            category.Name = "category";
            category.Size = new Size(355, 20);
            category.TabIndex = 3;
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
            // time
            // 
            time.Location = new Point(170, 115);
            time.Margin = new Padding(3, 4, 3, 4);
            time.Mask = "90:00:00";
            time.Name = "time";
            time.Size = new Size(355, 27);
            time.TabIndex = 6;
            time.ValidatingType = typeof(DateTime);
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
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(170, 155);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(355, 27);
            dateTimePicker.TabIndex = 15;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(817, 544);
            Controls.Add(dateTimePicker);
            Controls.Add(cancel_btn);
            Controls.Add(save_button);
            Controls.Add(participants);
            Controls.Add(label6);
            Controls.Add(description);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(time);
            Controls.Add(label3);
            Controls.Add(category);
            Controls.Add(category_lbl);
            Controls.Add(title);
            Controls.Add(title_lbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox participants;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_btn;
        private DateTimePicker dateTimePicker;
    }
}