namespace VirtualEvents
{
    /// <summary>
    /// Модель таблицы базы данных
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Индефикационный ключ события
        /// </summary>
        public int EventID { get; set; }
        /// <summary>
        /// Название события
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Описание события
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Дата проведения события
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Время проведения события
        /// </summary>
        public TimeSpan Time { get; set; }
        /// <summary>
        /// Категория события
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Участники события
        /// </summary>
        public string Participants { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Title))
                throw new ArgumentException("Заголовок должен быть заполнен");
            if (!char.IsUpper(Title[0]))
                throw new ArgumentException("Заголовок должен начинаться с заглавной буквы");
            if (char.IsSymbol(Title[0]) || char.IsPunctuation(Title[0]))
                throw new ArgumentException("Заголовок не может начинаться со специальных знаков");
            if (Title.Length > 35)
                throw new ArgumentException("Заголовок может содержать максимум 35 символов");
            if (Date < DateTime.Now)
                throw new ArgumentException("Дата события не может быть раньше сегодняшней");
            if (!string.IsNullOrEmpty(Description) && !char.IsUpper(Description[0]))
                throw new ArgumentException("Описание должно начинаться с заглавной буквы");
            if (!string.IsNullOrEmpty(Category) && !char.IsUpper(Category[0]))
                throw new ArgumentException("Категория должен начинаться с заглавной буквы");
            if (!string.IsNullOrEmpty(Participants))
            {
                var participantNames = Participants.Split(',');

                foreach (var participant in participantNames)
                {
                    if (string.IsNullOrWhiteSpace(participant) || !char.IsUpper(participant.Trim()[0]))
                    {
                        throw new ArgumentException("Имена участников должны начинаться с заглавной буквы");
                    }
                }
                if (Participants.Length > 300)
                {
                    throw new ArgumentException("Список участников может содержать максимум 300 символов");
                }
            }
            if (Time.Hours < 0 || Time.Hours > 23)
                throw new ArgumentException("Значение часов должно быть от 0 до 23");
            if (Time.Minutes < 0 || Time.Minutes > 59)
                throw new ArgumentException("Значение минут должно быть от 0 до 59");
            if (Time.Seconds < 0 || Time.Seconds > 59)
                throw new ArgumentException("Значение секунд должно быть от 0 до 59");
        }
    }
}