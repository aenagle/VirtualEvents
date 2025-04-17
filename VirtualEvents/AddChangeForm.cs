namespace VirtualEvents
{
    public partial class AddChangeForm : Form
    {
        /// <summary>
        /// Переменнная, которая хранит событие для редактирования
        /// </summary>
        public Event _event;
        public AddChangeForm()
        {
            InitializeComponent();
            datePicker.MinDate = DateTime.Today;
        }
        /// <summary>
        /// Конструктор для редактирования существующего события
        /// </summary>
        /// <param name="existingEvent"></param>
        public AddChangeForm(Event existingEvent) : this()
        {
            _event = existingEvent;
            LoadEventData();
        }
        /// <summary>
        /// Метод, загружающий данные из события для редактирования в элементы управления формы
        /// </summary>
        public void LoadEventData()
        {
            title.Text = _event.Title;
            description.Text = _event.Description;
            datePicker.Value = _event.Date;
            comboBoxCategory_AddForm.Text = _event.Category;
            participants.Text = _event.Participants;
        }
        /// <summary>
        /// Событие при нажатии кнопки Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void save_button_Click(object sender, EventArgs e)
        {
            if (_event != null) //  редактирование
            {
                _event.Title = title.Text;
                _event.Description = description.Text;
                _event.Date = datePicker.Value;
                _event.Time = timePicker.Value.TimeOfDay;
                _event.Category = comboBoxCategory_AddForm.Text;
                _event.Participants = participants.Text;

                using (var db = new EventContext())
                {
                    db.Events.Update(_event);
                    db.SaveChanges();
                    MessageBox.Show("Событие обновлено!", "Уведомление");
                    Close();
                }
            }
            else
            {
                var newEvent = new Event
                {
                    Title = title.Text,
                    Description = description.Text,
                    Date = datePicker.Value,
                    Category = comboBoxCategory_AddForm.Text,
                    Participants = participants.Text
                };

                using (var db = new EventContext())
                {
                    db.Events.Add(newEvent);
                    db.SaveChanges();
                    MessageBox.Show("Событие сохранено!", "Уведомление");
                    Close();
                }
            }
        }
        /// <summary>
        /// Событие при нажатии кнопки Отменить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cancel_btn_Click(object sender, EventArgs e) => Close();
        /// <summary>
        /// Проверка поля ввода Заголовка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void title_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title.Text))
            {
                title.BackColor = Color.LightCoral;
                e.Cancel = true;
            }
            else
            {
                title.BackColor = Color.White;
            }
        }

        private void title_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(title.Text))
            {
                string text = title.Text;
                string firstChar = text.Substring(0, 1).ToUpper();
                string rest = text.Length > 1 ? text.Substring(1) : "";
                string newText = firstChar + rest;

                if (title.Text != newText)
                {
                    int selectionStart = title.SelectionStart;
                    title.Text = newText;
                    title.SelectionStart = selectionStart;
                }
            }
        }
    }
}