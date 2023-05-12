namespace WebAPITest.Serialize
{
    public class UsersPrivate
    {
        /// <summary>
        /// Класс для сериализации таблицы users_private
        /// </summary>
        /// <param>
        /// id - Идентификатор
        /// fio - ФИО группы
        /// phone - Телефон сотрудника
        /// email - Электронная почта человека
        /// birthday - Дата рождения человека
        /// passport - Серия и номер паспорта человека
        /// login - Логин человека
        /// password - Пароль человека
        /// date - Дата посещения человека
        /// comments - Комментарий
        /// </param>
        public int id { get; set; }
        public string fio { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime birthday { get; set; }
        public string passport { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime date { get; set; }
        public string comments { get; set; }
        public int organization { get; set; }
    }
}
