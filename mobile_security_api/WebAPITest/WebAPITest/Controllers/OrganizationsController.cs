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
    /// Контроллер для добавления / получения данных из таблицы Organizations
    /// </summary>
    /// <param>
    /// AddOrganizations - добавление (POST запрос)
    /// GetOrganizations - получение (GET запрос)
    /// DeleteOrganizations - удаление (DELETE запрос)
    /// </param>
    public class OrganizationsController : ControllerBase
    {
        static string connString = "Data Source=wsr-server;Initial Catalog=User06;User ID=User06;Password=NKSX4NHH";
        // POST на внесение групп
        [HttpPost]
        public HttpStatusCode AddOrganizations(Organizations _organizations)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM users_group",conn);
                SqlCommand cmd = new SqlCommand("insert into organizations(name,contact_name,contact_phone)" +
                    $"values ('{_organizations.name}','{_organizations.contact_name}','{_organizations.contact_phone}',);", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                return HttpStatusCode.Accepted;
            }
            catch (Exception ex)
            {
                Console.WriteLine("При добавлении организации произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest;
            }
        }
        [HttpGet]
        // GET на получение групп
        public string GetOrganizations()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM users_group",conn);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM organizations", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                conn.Close();
                List<UsersGroup> groupList = new List<UsersGroup> { new UsersGroup() };
                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                string json = JsonSerializer.Serialize(dt);
                return json;
            }
            catch (Exception ex)
            {
                Console.WriteLine("При получении организации произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest.ToString();
            }
        }
        [HttpDelete]
        // Delete для удаления групп
        public HttpStatusCode DeleteOrganizations(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM organizations where id = {id};", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return HttpStatusCode.Accepted;
            }
            catch (Exception ex)
            {
                Console.WriteLine("При удалении организации произошла ошибка: " + ex + "\n Обратитесь к системному администратору за помощью.");
                return HttpStatusCode.BadRequest;
            }
        }
    }
}
