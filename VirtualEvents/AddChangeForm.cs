namespace VirtualEvents
{
    public partial class AddChangeForm : Form
    {
        public AddChangeForm()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            using (var db = new EventContext())
            {
                var newEvent = new Event
                {
                    Title = title.Text,
                    Description = description.Text,
                    //Date = dateTimePicker.Value,
                    //Time
                    Category = category.Text,
                    Participants = participants.Text
                };
                db.Events.Add(newEvent);
                db.SaveChanges();
                Close();
                MessageBox.Show("Событие сохранено!");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void title_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(title.Text))
            {
                title.BackColor = Color.LightCoral; // Красный цвет для обязательного поля
                e.Cancel = true; // Отменяем событие
            }
            else
            {
                title.BackColor = Color.White; // Сбрасываем цвет
            }
        }
    }
}