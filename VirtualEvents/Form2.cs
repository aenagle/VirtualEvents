namespace VirtualEvents
{
    public partial class Form2 : Form
    {
        public Form2()
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
                    //Date = date.Value.Date,
                    //Time = time.Value.TimeOfDay,
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
    }
}