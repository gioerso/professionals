using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using WebAPITest.Serialize;
using System.Runtime.CompilerServices;
using System.Net;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /// <summary>
    /// Контроллер для добавления / получения данных из таблицы UsersGroup
    /// </summary>
    /// <param>
    /// AddUsersGroup - добавление (POST запрос)
    /// GetUsersGroup - получение (GET запрос)
    /// DeleteUsers - удаление (DELETE запрос)
    /// </param>
    public class UsersGroupController : ControllerBase
    {
        static string connString = "Data Source=wsr-server;Initial Catalog=User06;User ID=User06;Password=NKSX4NHH";
        // POST на внесение
        [HttpPost]
        public HttpStatusCode AddUsersGroup(UsersGroup usersGroup)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM users_group",conn);
                SqlCommand cmd = new SqlCommand("insert into users_group(fio,phone,email,birthday,passport,login,password,group_id,date,photo,passport_scan,group_table)" +
                    $"values ('{usersGroup.fio}','{usersGroup.phone}','{usersGroup.email}','{usersGroup.birthday}','{usersGroup.passport}','{usersGroup.login}','{usersGroup.password}','{usersGroup.group_id}','{usersGroup.date}','{usersGroup.photo}','{usersGroup.passport_scan}','{usersGroup.group_table}');", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                return HttpStatusCode.Accepted;
            }
            catch(Exception ex)
            {
                Console.WriteLine("При добавлении Группового посещения произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest;
            }
        }
        [HttpGet]
        public string GetUsersGroup()
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM users_group",conn);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM users_group", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            List<UsersGroup> groupList = new List<UsersGroup> { new UsersGroup() };
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            string json = JsonSerializer.Serialize(dt);
            return json;
        }
        [HttpDelete]
        public HttpStatusCode DeleteUsersGroup(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM users_group where id = {id};", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return HttpStatusCode.Accepted;
            }
            catch (Exception ex) {
                Console.WriteLine("При удалении Группового посещения произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest;
            }
        }
    }
}
