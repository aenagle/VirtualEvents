using System.Windows.Forms;

namespace VirtualEvents
{
    public partial class MainForm : Form
    {
        private EventContext db;
        private Event selectedEvent;
        public MainForm()
        {
            InitializeComponent();
            db = new EventContext();
            LoadEvents();
        }
        private void LoadEvents()
        {
            using (var db = new EventContext())
            {
                list_Of_Events.Items.Clear();
                var events = db.Events.ToList();

                foreach (var eventItem in events)
                {
                    list_Of_Events.Items.Add(eventItem.Title);
                }
            }
        }
        private void create_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            LoadEvents();
        }
        private void list_Of_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            selectedEvent = list_Of_Events.SelectedItem as Event;
            using (var db = new EventContext())
            {
                if (selectedEvent != null)
                {
                    title_Of_Event.Text = selectedEvent.Title;
                    description_Of_Event.Text = selectedEvent.Description;
                    //date 
                    //time
                    category_Of_Event.Text = selectedEvent.Category;
                    participants_Of_Event.Text = selectedEvent.Participants;
                }
                else { MessageBox.Show("ОШИБКА"); }
            }
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (list_Of_Events.SelectedIndex != null)
            {
                string selectedEventName = list_Of_Events.SelectedItem.ToString();

                using (var db = new EventContext())
                {
                    // Находим событие по названию
                    var itemToDelete = db.Events.FirstOrDefault(e => e.Title == selectedEventName);
                    if (itemToDelete != null)
                    {
                        // Удаляем событие из базы данных
                        db.Events.Remove(itemToDelete);
                        db.SaveChanges();

                        // Удаляем элемент из ListBox
                        list_Of_Events.Items.RemoveAt(list_Of_Events.SelectedIndex);
                        MessageBox.Show("Событие удалено!");
                    }
                    else
                    {
                        MessageBox.Show("Событие не найдено в базе данных.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите событие для удаления.");
            }
        }
    }
}