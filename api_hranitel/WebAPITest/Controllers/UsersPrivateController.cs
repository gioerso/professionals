using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text.Json;
using WebAPITest.Serialize;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /// <summary>
    /// Контроллер для добавления / получения данных из таблицы UsersPrivate 
    /// </summary>
    /// <param>
    /// AddUsersPrivate - добавление (POST запрос)
    /// GetUsersPrivate  - получение (GET запрос)
    /// DeleteUsersPrivate  - удаление (DELETE запрос)
    /// </param>
    public class UsersPrivateController : ControllerBase
    {
        static string connString = "Data Source=wsr-server;Initial Catalog=User06;User ID=User06;Password=NKSX4NHH";
        [HttpPost]
        public HttpStatusCode AddUsersPrivate(UsersPrivate usersPrivate)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM users_group",conn);
                SqlCommand cmd = new SqlCommand("insert into users_private(fio,phone,email,birthday,passport,login,password,date,comments,organization)" +
                    $"values ('{usersPrivate.fio}','{usersPrivate.phone}','{usersPrivate.email}','{usersPrivate.birthday}','{usersPrivate.passport}','{usersPrivate.login}','{usersPrivate.password}','{usersPrivate.date}','{usersPrivate.comments}','{usersPrivate.organization}');", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                return HttpStatusCode.Accepted;
            }
            catch (Exception ex)
            {
                Console.WriteLine("При добавлении личного посещения произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest;
            }
        }
        [HttpGet]
        public string GetUsersPrivate()
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

            string json = JsonSerializer.Serialize(ds);
            return json;
        }
        [HttpDelete]
        public HttpStatusCode DeleteUsersPrivate(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM users_private where id = {id};", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return HttpStatusCode.Accepted;
            }
            catch (Exception ex)
            {
                Console.WriteLine("При удалении Личного посещения произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest;
            }
        }
    }
}
