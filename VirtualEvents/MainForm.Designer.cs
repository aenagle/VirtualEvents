namespace VirtualEvents
{
    public partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            delete_btn = new Button();
            fontDialog1 = new FontDialog();
            mainPanel = new Panel();
            dateTimePicker_MainForm = new DateTimePicker();
            participants_Of_Event = new TextBox();
            paticipanrs_lbl = new Label();
            description_Of_Event = new TextBox();
            description_lbl = new Label();
            category_lbl = new Label();
            category_Of_Event = new TextBox();
            dateTime_lbl = new Label();
            mainPanelVisible = new Panel();
            list_Of_Events = new ListBox();
            listEvents = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel = new Panel();
            change_btn = new Button();
            comboBoxCategory = new ComboBox();
            title_Of_Event = new Label();
            generate_Report = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // create_btn
            // 
            create_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            create_btn.BackColor = Color.FromArgb(224, 193, 69);
            create_btn.FlatStyle = FlatStyle.Popup;
            create_btn.ForeColor = SystemColors.ButtonHighlight;
            create_btn.Location = new Point(442, 485);
            create_btn.Margin = new Padding(3, 4, 3, 4);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(92, 39);
            create_btn.TabIndex = 0;
            create_btn.Text = "Создать";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            delete_btn.BackColor = Color.FromArgb(192, 0, 0);
            delete_btn.FlatStyle = FlatStyle.Popup;
            delete_btn.ForeColor = SystemColors.ButtonHighlight;
            delete_btn.Location = new Point(665, 485);
            delete_btn.Margin = new Padding(3, 4, 3, 4);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(92, 39);
            delete_btn.TabIndex = 3;
            delete_btn.Text = "Удалить";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Visible = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(217, 217, 217);
            mainPanel.Controls.Add(dateTimePicker_MainForm);
            mainPanel.Controls.Add(participants_Of_Event);
            mainPanel.Controls.Add(paticipanrs_lbl);
            mainPanel.Controls.Add(description_Of_Event);
            mainPanel.Controls.Add(description_lbl);
            mainPanel.Controls.Add(category_lbl);
            mainPanel.Controls.Add(category_Of_Event);
            mainPanel.Controls.Add(dateTime_lbl);
            mainPanel.Location = new Point(266, 57);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(490, 403);
            mainPanel.TabIndex = 5;
            mainPanel.Visible = false;
            // 
            // dateTimePicker_MainForm
            // 
            dateTimePicker_MainForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker_MainForm.Location = new Point(161, 120);
            dateTimePicker_MainForm.Name = "dateTimePicker_MainForm";
            dateTimePicker_MainForm.RightToLeftLayout = true;
            dateTimePicker_MainForm.Size = new Size(281, 27);
            dateTimePicker_MainForm.TabIndex = 12;
            // 
            // participants_Of_Event
            // 
            participants_Of_Event.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            participants_Of_Event.BackColor = SystemColors.Control;
            participants_Of_Event.BorderStyle = BorderStyle.None;
            participants_Of_Event.Location = new Point(164, 315);
            participants_Of_Event.Margin = new Padding(3, 4, 3, 4);
            participants_Of_Event.Multiline = true;
            participants_Of_Event.Name = "participants_Of_Event";
            participants_Of_Event.ReadOnly = true;
            participants_Of_Event.ScrollBars = ScrollBars.Vertical;
            participants_Of_Event.Size = new Size(278, 28);
            participants_Of_Event.TabIndex = 11;
            // 
            // paticipanrs_lbl
            // 
            paticipanrs_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            paticipanrs_lbl.AutoSize = true;
            paticipanrs_lbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            paticipanrs_lbl.Location = new Point(18, 315);
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
            description_Of_Event.Size = new Size(278, 111);
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
            category_Of_Event.Size = new Size(278, 20);
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
            // mainPanelVisible
            // 
            mainPanelVisible.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanelVisible.BackColor = Color.FromArgb(217, 217, 217);
            mainPanelVisible.Location = new Point(267, 58);
            mainPanelVisible.Name = "mainPanelVisible";
            mainPanelVisible.Size = new Size(490, 402);
            mainPanelVisible.TabIndex = 12;
            // 
            // list_Of_Events
            // 
            list_Of_Events.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            list_Of_Events.BackColor = Color.FromArgb(217, 217, 217);
            list_Of_Events.BorderStyle = BorderStyle.None;
            list_Of_Events.FormattingEnabled = true;
            list_Of_Events.Location = new Point(0, 60);
            list_Of_Events.Name = "list_Of_Events";
            list_Of_Events.Size = new Size(240, 400);
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
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(240, 63);
            panel.TabIndex = 8;
            // 
            // change_btn
            // 
            change_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            change_btn.BackColor = Color.FromArgb(0, 192, 192);
            change_btn.FlatStyle = FlatStyle.Popup;
            change_btn.ForeColor = SystemColors.ButtonHighlight;
            change_btn.Location = new Point(554, 485);
            change_btn.Margin = new Padding(3, 4, 3, 4);
            change_btn.Name = "change_btn";
            change_btn.Size = new Size(92, 39);
            change_btn.TabIndex = 2;
            change_btn.Text = "Изменить";
            change_btn.UseVisualStyleBackColor = false;
            change_btn.Visible = false;
            change_btn.Click += change_btn_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxCategory.BackColor = Color.FromArgb(217, 217, 217);
            comboBoxCategory.CausesValidation = false;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.ImeMode = ImeMode.On;
            comboBoxCategory.Items.AddRange(new object[] { "По умолчанию", "По категории", "По дате" });
            comboBoxCategory.Location = new Point(0, 441);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(240, 28);
            comboBoxCategory.TabIndex = 13;
            comboBoxCategory.Text = "Сортировать";
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // title_Of_Event
            // 
            title_Of_Event.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title_Of_Event.ForeColor = Color.FromArgb(224, 193, 69);
            title_Of_Event.Location = new Point(266, 9);
            title_Of_Event.Name = "title_Of_Event";
            title_Of_Event.Size = new Size(491, 37);
            title_Of_Event.TabIndex = 14;
            title_Of_Event.TextAlign = ContentAlignment.TopCenter;
            // 
            // generate_Report
            // 
            generate_Report.Location = new Point(12, 485);
            generate_Report.Name = "generate_Report";
            generate_Report.Size = new Size(94, 39);
            generate_Report.TabIndex = 15;
            generate_Report.Text = "Отчёт";
            generate_Report.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(generate_Report);
            Controls.Add(title_Of_Event);
            Controls.Add(comboBoxCategory);
            Controls.Add(mainPanel);
            Controls.Add(delete_btn);
            Controls.Add(change_btn);
            Controls.Add(listEvents);
            Controls.Add(list_Of_Events);
            Controls.Add(create_btn);
            Controls.Add(panel);
            Controls.Add(mainPanelVisible);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = " Events";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Button create_btn;
        public System.Windows.Forms.Button delete_btn;
        public System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Label dateTime_lbl;
        public System.Windows.Forms.TextBox category_Of_Event;
        public System.Windows.Forms.Label category_lbl;
        public System.Windows.Forms.TextBox description_Of_Event;
        public System.Windows.Forms.Label description_lbl;
        public System.Windows.Forms.TextBox participants_Of_Event;
        public System.Windows.Forms.Label paticipanrs_lbl;
        public ListBox list_Of_Events;
        public Label listEvents;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Panel panel;
        public Button change_btn;
        public Panel mainPanelVisible;
        public DateTimePicker dateTimePicker_MainForm;
        public ComboBox comboBoxCategory;
        private Label title_Of_Event;
        private Button generate_Report;
    }
}
