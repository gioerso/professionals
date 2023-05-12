namespace WebAPITest.Serialize
{
    /// <summary>
    /// Класс для сериализации таблицы Groups 
    /// </summary>
    /// <param>
    /// id - Идентификатор
    /// group_name - Название группы
    /// emp - Имя ответственного сотрудника
    /// </param>
    public class Groups
    {
        /// <summary>
        /// Класс для сериализации таблицы Groups 
        /// </summary>
        /// <param>
        /// id - Идентификатор
        /// group_name - Название группы
        /// emp - Имя ответственного сотрудника
        /// </param>
        public int id { get; set; }
        public string group_name { get; set; }
        public string emp { get; set; }
    }
}
