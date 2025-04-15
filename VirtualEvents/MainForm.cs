using System.Windows.Forms;

namespace VirtualEvents
{
    public partial class MainForm : Form
    {
        private EventContext db;
        Dictionary<string, Event> eventDictionary = new Dictionary<string, Event>();

        public MainForm()
        {
            InitializeComponent();
            db = new EventContext();
            LoadEvents();
        }

        private void LoadEvents()
        {
            list_Of_Events.Items.Clear();
            var events = db.Events.ToList();
            foreach (Event ev in events)
            { 
                eventDictionary[ev.Title] = ev;
                list_Of_Events.Items.Add(ev.Title); // добавл€ет только название в list_Of_Events
            }
        }
        private void create_btn_Click(object sender, EventArgs e)
        {
            AddChangeForm form2 = new AddChangeForm();
            form2.ShowDialog();
            LoadEvents();
        }
        private void list_Of_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Of_Events.SelectedItem != null)
            {
                string selectedTitle = list_Of_Events.SelectedItem.ToString();
                if (eventDictionary.ContainsKey(selectedTitle))
                {
                    Event selectedEvent = eventDictionary[selectedTitle];

                    title_Of_Event.Text = selectedEvent.Title;
                    description_Of_Event.Text = selectedEvent.Description;
                    //date 
                    //time
                    category_Of_Event.Text = selectedEvent.Category;
                    participants_Of_Event.Text = selectedEvent.Participants;
                    mainPanel.Visible = true;
                }
            }
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (list_Of_Events.SelectedIndex != -1)
            {
                string selectedTitle = list_Of_Events.SelectedItem.ToString();
                using (var db = new EventContext())
                {
                    // находим событие по названию
                    var itemToDelete = db.Events.FirstOrDefault(e => e.Title == selectedTitle);
                    if (itemToDelete != null)
                    {
                        db.Events.Remove(itemToDelete);
                        db.SaveChanges();

                        list_Of_Events.Items.RemoveAt(list_Of_Events.SelectedIndex);

                        title_Of_Event.Clear();
                        description_Of_Event.Clear();
                        category_Of_Event.Clear();
                        participants_Of_Event.Clear();
                        mainPanel.Visible = false;
                        MessageBox.Show("—обытие удалено!");
                    }
                }
            }
            else
            {
                MessageBox.Show("ѕожалуйста, выберите событие дл€ удалени€.");
            }
        }
    }
}