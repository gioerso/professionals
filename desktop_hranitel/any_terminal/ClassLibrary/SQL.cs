using System.Data;
using System.Data.SqlClient;


namespace ClassLibrary
{
    /// <summary>
    /// Класс для работы с SQL запросами
    /// <para>
    /// ReturnDataTable - возвращает экземпляр класса DataTable по строке запроса
    /// </para>
    /// <para>
    /// ExecuteScalar - возвращает скалярное выражение первого обьекта по строке запроса
    /// </para>
    /// <para>
    /// ExecuteNonQuery - возвращает количество строк, которые подверглись изменению после запроса
    /// </para>
    /// </summary>
    public class SQL
    {
        static string connString = "Data Source=wsr-server;Initial Catalog=User06;User ID=User06;Password=NKSX4NHH";
        /// <summary>
        /// Возвращает DataTable по строке запроса.
        /// </summary>
        /// <param name="query">
        /// Строка запроса
        /// </param>
        /// <returns>
        /// DataTabe по строке запроса
        /// </returns>
        public DataTable ReturnDataTable(string query)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"{query}", conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            conn.Close();

            DataTable dt = new DataTable();
            dt = dataSet.Tables[0];
            return dt;
        }
        /// <summary>
        /// Возвращает скалярное выражение первого обьекта по строке запроса
        /// </summary>
        /// <param name="query">Строка запроса</param>
        /// <returns>скалярное выражение</returns>
        public string ExecuteScalar(string query)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand($"{query}", conn);
            string returnMessage = cmd1.ExecuteScalar().ToString();
            returnMessage = returnMessage.Replace("\r\n", "");
            conn.Close();

            return returnMessage;
        }
        /// <summary>
        /// Возвращает количество строк, которые подверглись изменению после запроса
        /// </summary>
        /// <param name="query">
        /// Строка запроса
        /// </param>
        /// <returns>
        /// Количество строк, которые подверглись изменению после запроса
        /// </returns>
        public string ExecuteNonQuery(string query)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand($"{query}", conn);
            string returnMessage = cmd1.ExecuteNonQuery().ToString();
            returnMessage = returnMessage.Replace("\r\n", "");
            conn.Close();

            return returnMessage;
        }
    }
}
