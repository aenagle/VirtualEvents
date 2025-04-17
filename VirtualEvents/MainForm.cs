namespace VirtualEvents
{
    public partial class MainForm : Form
    {
        private EventContext db;
        private Event? selectedEvent;
        public MainForm()
        {
            InitializeComponent();
            db = new EventContext();
            LoadEvents();
            //dateTimePicker_MainForm.ForeColor = SystemColors.Control;
        }
        /// <summary>
        /// Метод для выгрузки событий в ListBox
        /// </summary>
        public void LoadEvents()
        {
            list_Of_Events.DataSource = db.Events.ToList();
            list_Of_Events.DisplayMember = "Title";
        }
        /// <summary>
        /// Событие при нажатии кнопки Создать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void create_btn_Click(object sender, EventArgs e)
        {
            var form2 = new AddChangeForm();
            form2.ShowDialog();
            LoadEvents();
        }
        private void list_Of_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEvent = (Event?)list_Of_Events.SelectedItem;
            if (list_Of_Events.SelectedItem != null)
            {
                title_Of_Event.Text = selectedEvent.Title;
                description_Of_Event.Text = selectedEvent.Description;
                dateTimePicker_MainForm.Value = selectedEvent.Date;
                category_Of_Event.Text = selectedEvent.Category;
                participants_Of_Event.Text = selectedEvent.Participants;
                mainPanel.Visible = true;
                change_btn.Visible = true;
                delete_btn.Visible = true;
            }
        }
        /// <summary>
        /// Событие при нажатии кнопки Удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void delete_btn_Click(object sender, EventArgs e)
        {
            if (selectedEvent != null && MessageBox.Show("Вы хотите удалить это событие?", "Подтверждение",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedEvent = (Event)list_Of_Events.SelectedItem;

                var eventToDelete = db.Events.Find(selectedEvent.EventID);
                if (eventToDelete != null)
                {
                    db.Events.Remove(eventToDelete);
                    db.SaveChanges();
                    LoadEvents();

                    title_Of_Event.Clear();
                    description_Of_Event.Clear();
                    category_Of_Event.Clear();
                    participants_Of_Event.Clear();
                    mainPanel.Visible = false;
                    delete_btn.Visible = false;
                    change_btn.Visible = false;
                    MessageBox.Show("Событие удалено.", "Уведомление");
                }
                else
                {
                    MessageBox.Show("Событие не найдено.");
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать событие для удаления.");
            }
        }
        /// <summary>
        /// Событие при нажатии кнопки Изменить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void change_btn_Click(object sender, EventArgs e)
        {
            if (list_Of_Events.SelectedItem is Event selectedEvent)
            {
                var eventToEdit = db.Events.Find(selectedEvent.EventID);
                if (eventToEdit != null)
                {
                    var form2 = new AddChangeForm(eventToEdit); // передаем событие в форму
                    form2.ShowDialog();
                    LoadEvents();
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать событие для редактирования.");
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCategory.SelectedIndex)
            {
                case 0:
                    LoadEvents();
                    break;
                case 1:
                    list_Of_Events.DataSource = db.Events
                        .OrderBy(ev => ev.Category)
                        .ToList();
                    break;
                case 2:
                    list_Of_Events.DataSource = db.Events
                         .OrderBy(ev => ev.Date)
                         .ToList();
                    break;
                default:
                    LoadEvents();
                    break;
            }
        }
    }
}