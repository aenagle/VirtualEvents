namespace VirtualEvents
{
    public partial class Form1 : Form
    {
        private EventContext db;
        private Event selectedEvent;
        public Form1()
        {
            InitializeComponent();
            db = new EventContext();
            LoadEvents();
        }
        private void LoadEvents()
        {
            var events = db.Events.ToList();
            list_Of_Events.DataSource = events;
            list_Of_Events.DisplayMember = "Title";

        }
        private void create_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            LoadEvents();
        }
        private void list_Of_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEvent = (Event)list_Of_Events.SelectedItem;

            if (selectedEvent != null)
            {
                title_Of_Event.Text = selectedEvent.Title;
                description_Of_Event.Text = selectedEvent.Description;
                //date 
                //time
                category_Of_Event.Text = selectedEvent.Category;
                participants_Of_Event.Text = selectedEvent.Participants;
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (selectedEvent != null)
            {
                db.Events.Remove(selectedEvent);
                db.SaveChanges();
                LoadEvents();
            }
        }
    }
}