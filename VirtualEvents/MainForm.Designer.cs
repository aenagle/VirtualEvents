namespace VirtualEvents
{
    partial class MainForm
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
            create_btn = new Button();
            change_btn = new Button();
            delete_btn = new Button();
            fontDialog1 = new FontDialog();
            title_Of_Event = new TextBox();
            mainPanel = new Panel();
            participants_Of_Event = new TextBox();
            paticipanrs_lbl = new Label();
            description_Of_Event = new TextBox();
            description_lbl = new Label();
            category_lbl = new Label();
            category_Of_Event = new TextBox();
            dateTime_lbl = new Label();
            maskedTextBox2 = new MaskedTextBox();
            list_Of_Events = new ListBox();
            listEvents = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel = new Panel();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // create_btn
            // 
            create_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            create_btn.BackColor = Color.FromArgb(224, 193, 69);
            create_btn.FlatStyle = FlatStyle.Popup;
            create_btn.ForeColor = SystemColors.ButtonHighlight;
            create_btn.Location = new Point(68, 491);
            create_btn.Margin = new Padding(3, 4, 3, 4);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(92, 39);
            create_btn.TabIndex = 0;
            create_btn.Text = "Создать";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // change_btn
            // 
            change_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            change_btn.BackColor = Color.FromArgb(0, 192, 192);
            change_btn.FlatStyle = FlatStyle.Popup;
            change_btn.ForeColor = SystemColors.ButtonHighlight;
            change_btn.Location = new Point(564, 491);
            change_btn.Margin = new Padding(3, 4, 3, 4);
            change_btn.Name = "change_btn";
            change_btn.Size = new Size(92, 39);
            change_btn.TabIndex = 2;
            change_btn.Text = "Изменить";
            change_btn.UseVisualStyleBackColor = false;
            // 
            // delete_btn
            // 
            delete_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            delete_btn.BackColor = Color.FromArgb(192, 0, 0);
            delete_btn.FlatStyle = FlatStyle.Popup;
            delete_btn.ForeColor = SystemColors.ButtonHighlight;
            delete_btn.Location = new Point(679, 491);
            delete_btn.Margin = new Padding(3, 4, 3, 4);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(92, 39);
            delete_btn.TabIndex = 3;
            delete_btn.Text = "Удалить";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // title_Of_Event
            // 
            title_Of_Event.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            title_Of_Event.BackColor = SystemColors.Control;
            title_Of_Event.BorderStyle = BorderStyle.None;
            title_Of_Event.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title_Of_Event.ForeColor = Color.FromArgb(224, 193, 69);
            title_Of_Event.Location = new Point(267, 6);
            title_Of_Event.Margin = new Padding(3, 4, 3, 4);
            title_Of_Event.Name = "title_Of_Event";
            title_Of_Event.ReadOnly = true;
            title_Of_Event.Size = new Size(504, 37);
            title_Of_Event.TabIndex = 4;
            title_Of_Event.TextAlign = HorizontalAlignment.Center;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(217, 217, 217);
            mainPanel.Controls.Add(participants_Of_Event);
            mainPanel.Controls.Add(paticipanrs_lbl);
            mainPanel.Controls.Add(description_Of_Event);
            mainPanel.Controls.Add(description_lbl);
            mainPanel.Controls.Add(category_lbl);
            mainPanel.Controls.Add(category_Of_Event);
            mainPanel.Controls.Add(dateTime_lbl);
            mainPanel.Controls.Add(maskedTextBox2);
            mainPanel.Location = new Point(267, 58);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(504, 420);
            mainPanel.TabIndex = 5;
            mainPanel.Visible = false;
            // 
            // participants_Of_Event
            // 
            participants_Of_Event.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            participants_Of_Event.BackColor = SystemColors.Control;
            participants_Of_Event.BorderStyle = BorderStyle.None;
            participants_Of_Event.Location = new Point(164, 332);
            participants_Of_Event.Margin = new Padding(3, 4, 3, 4);
            participants_Of_Event.Multiline = true;
            participants_Of_Event.Name = "participants_Of_Event";
            participants_Of_Event.ReadOnly = true;
            participants_Of_Event.ScrollBars = ScrollBars.Vertical;
            participants_Of_Event.Size = new Size(281, 28);
            participants_Of_Event.TabIndex = 11;
            // 
            // paticipanrs_lbl
            // 
            paticipanrs_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            paticipanrs_lbl.AutoSize = true;
            paticipanrs_lbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            paticipanrs_lbl.Location = new Point(18, 332);
            paticipanrs_lbl.Name = "paticipanrs_lbl";
            paticipanrs_lbl.Size = new Size(103, 20);
            paticipanrs_lbl.TabIndex = 10;
            paticipanrs_lbl.Text = "Участники:";
            // 
            // description_Of_Event
            // 
            description_Of_Event.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            description_Of_Event.BackColor = SystemColors.Control;
            description_Of_Event.BorderStyle = BorderStyle.None;
            description_Of_Event.Location = new Point(164, 196);
            description_Of_Event.Margin = new Padding(3, 4, 3, 4);
            description_Of_Event.Multiline = true;
            description_Of_Event.Name = "description_Of_Event";
            description_Of_Event.ReadOnly = true;
            description_Of_Event.RightToLeft = RightToLeft.No;
            description_Of_Event.ScrollBars = ScrollBars.Vertical;
            description_Of_Event.Size = new Size(281, 69);
            description_Of_Event.TabIndex = 7;
            // 
            // description_lbl
            // 
            description_lbl.AutoSize = true;
            description_lbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            description_lbl.Location = new Point(18, 196);
            description_lbl.Name = "description_lbl";
            description_lbl.Size = new Size(96, 20);
            description_lbl.TabIndex = 6;
            description_lbl.Text = "Описание:";
            // 
            // category_lbl
            // 
            category_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            category_lbl.AutoSize = true;
            category_lbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            category_lbl.Location = new Point(18, 55);
            category_lbl.Name = "category_lbl";
            category_lbl.Size = new Size(103, 20);
            category_lbl.TabIndex = 5;
            category_lbl.Text = "Категория:";
            // 
            // category_Of_Event
            // 
            category_Of_Event.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            category_Of_Event.BackColor = SystemColors.Control;
            category_Of_Event.BorderStyle = BorderStyle.None;
            category_Of_Event.Location = new Point(164, 55);
            category_Of_Event.Margin = new Padding(3, 4, 3, 4);
            category_Of_Event.Name = "category_Of_Event";
            category_Of_Event.ReadOnly = true;
            category_Of_Event.ScrollBars = ScrollBars.Vertical;
            category_Of_Event.Size = new Size(281, 20);
            category_Of_Event.TabIndex = 4;
            // 
            // dateTime_lbl
            // 
            dateTime_lbl.AutoSize = true;
            dateTime_lbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTime_lbl.Location = new Point(18, 125);
            dateTime_lbl.Name = "dateTime_lbl";
            dateTime_lbl.Size = new Size(129, 20);
            dateTime_lbl.TabIndex = 3;
            dateTime_lbl.Text = "Дата и время:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox2.BorderStyle = BorderStyle.None;
            maskedTextBox2.Location = new Point(164, 125);
            maskedTextBox2.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox2.Mask = "00/00/0000 90:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.ReadOnly = true;
            maskedTextBox2.Size = new Size(281, 20);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // list_Of_Events
            // 
            list_Of_Events.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            list_Of_Events.BackColor = Color.FromArgb(217, 217, 217);
            list_Of_Events.BorderStyle = BorderStyle.None;
            list_Of_Events.FormattingEnabled = true;
            list_Of_Events.Location = new Point(-2, 58);
            list_Of_Events.Name = "list_Of_Events";
            list_Of_Events.Size = new Size(241, 420);
            list_Of_Events.TabIndex = 6;
            list_Of_Events.SelectedIndexChanged += list_Of_Events_SelectedIndexChanged;
            // 
            // listEvents
            // 
            listEvents.AutoSize = true;
            listEvents.BackColor = Color.FromArgb(217, 217, 217);
            listEvents.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listEvents.Location = new Point(28, 16);
            listEvents.Name = "listEvents";
            listEvents.Size = new Size(178, 27);
            listEvents.TabIndex = 7;
            listEvents.Text = "Список событий";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(217, 217, 217);
            panel.Location = new Point(-2, -3);
            panel.Name = "panel";
            panel.Size = new Size(241, 63);
            panel.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 559);
            Controls.Add(listEvents);
            Controls.Add(list_Of_Events);
            Controls.Add(mainPanel);
            Controls.Add(delete_btn);
            Controls.Add(title_Of_Event);
            Controls.Add(change_btn);
            Controls.Add(create_btn);
            Controls.Add(panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = " ";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox title_Of_Event;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label dateTime_lbl;
        private System.Windows.Forms.TextBox category_Of_Event;
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.TextBox description_Of_Event;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.TextBox participants_Of_Event;
        private System.Windows.Forms.Label paticipanrs_lbl;
        private ListBox list_Of_Events;
        private Label listEvents;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel;
    }
}
