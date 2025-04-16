namespace VirtualEvents
{
    public partial class AddChangeForm : Form
    {
        private Event _event; // хранит событие для редактирования
        public AddChangeForm()
        {
            InitializeComponent();
            datePicker.MinDate = DateTime.Today;
        }
        // конструктор для редактирования существующего события
        public AddChangeForm(Event existingEvent) : this() //  основной конструктор
        {
            _event = existingEvent;
            LoadEventData();
        }
        public void LoadEventData()
        {
            title.Text = _event.Title;
            description.Text = _event.Description;
            datePicker.Value = _event.Date;
            comboBoxCategory_AddForm.Text = _event.Category;
            participants.Text = _event.Participants;
        }

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
        public void cancel_btn_Click(object sender, EventArgs e) => Close();

        public void title_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title.Text))
            {
                title.BackColor = Color.LightCoral;
                e.Cancel = true; // отмена события
            }
            else
            {
                title.BackColor = Color.White;
            }
        }
    }
}