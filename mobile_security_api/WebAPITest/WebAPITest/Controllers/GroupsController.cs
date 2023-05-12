using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using WebAPITest.Serialize;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /// <summary>
    /// Контроллер для добавления / получения данных из таблицы Groups
    /// </summary>
    /// <param>
    /// AddGroup - добавление (POST запрос)
    /// GetGroups - получение (GET запрос)
    /// DeleteGroups - удаление (DELETE запрос)
    /// </param>
    public class GroupsController : ControllerBase
    {
        static string connString = "Data Source=wsr-server;Initial Catalog=User06;User ID=User06;Password=NKSX4NHH";
        [HttpPost]
        public HttpStatusCode AddGroup(Groups groups)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM users_group",conn);
                SqlCommand cmd = new SqlCommand("insert into groups(group_name,emp)" +
                    $"values ('{groups.group_name}','{groups.emp}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                return HttpStatusCode.Accepted;
            }
            catch (Exception ex)
            {
                Console.WriteLine("При добавлении группы произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest;
            }
        }
        [HttpGet]
        public string GetGroups()
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM users_group",conn);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM users_private", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            List<UsersPrivate> groupList = new List<UsersPrivate> { new UsersPrivate() };
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            
            string json = JsonSerializer.Serialize(dt);
            return json;
        }
        [HttpDelete]
        public HttpStatusCode DeleteGroups(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM groups where id = {id};", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return HttpStatusCode.Accepted;
            }
            catch (Exception ex)
            {
                Console.WriteLine("При удалении группы произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest;
            }
        }

    }
}
