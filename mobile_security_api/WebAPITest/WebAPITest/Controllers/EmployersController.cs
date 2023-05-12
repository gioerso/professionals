using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Text.Json;
using WebAPITest.Serialize;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /// <summary>
    /// Контроллер для добавления / получения данных из таблицы Employers
    /// </summary>
    /// <param>
    /// AddEmployers - добавление (POST запрос)
    /// GetEmployers - получение (GET запрос)
    /// DeleteEmployers - удаление (DELETE запрос)
    /// </param>
    public class EmployersController : ControllerBase
    {
        static string connString = "Data Source=wsr-server;Initial Catalog=User06;User ID=User06;Password=NKSX4NHH";
        // POST на внесение групп
        [HttpPost]
        public HttpStatusCode AddEmployers(Employers _employers)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM users_group",conn);
                SqlCommand cmd = new SqlCommand("insert into employers(fio,unit,otdel,user_code)" +
                    $"values ('{_employers.fio}',{_employers.unit},{_employers.otdel},{_employers.user_code},);", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                return HttpStatusCode.Accepted;
            }
            catch (Exception ex)
            {
                Console.WriteLine("При добавлении сотрудника произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest;
            }
        }
        [HttpGet]
        // GET на получение групп
        public string GetEmployers()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM users_group",conn);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM employers", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                conn.Close();
                List<UsersGroup> groupList = new List<UsersGroup> { new UsersGroup() };
                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                string json = JsonSerializer.Serialize(dt);
                return json;
            }
            catch(Exception ex) {
                Console.WriteLine("При получении сотрудников произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest.ToString();
            }
        }
        [HttpDelete]
        // Delete для удаления групп
        public HttpStatusCode DeleteEmployers(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM employers where id = {id};", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return HttpStatusCode.Accepted;
            }
            catch (Exception ex)
            {
                Console.WriteLine("При удалении сотрудника произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest;
            }
        }
    }
}
