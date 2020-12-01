using KellyTestProject.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace KellyTestProject.Controllers
{   
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MsSqlContext dbContext;

        public UserController(MsSqlContext context)
        {
            dbContext = context;
        }
        [Route("api/GetTpoTenUsers")]
        public async Task<List<TopTenUsers>> GetTopTenUsers()
        {
            List<TopTenUsers> topTenUsers = new List<TopTenUsers>();
            using (SqlConnection connection = new SqlConnection(dbContext.Database.GetConnectionString()))
            {
                await connection.OpenAsync();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GetTopTenUsers";

                    try
                    {
                        var reader = await command.ExecuteReaderAsync();

                        while (await reader.ReadAsync())
                            topTenUsers.Add(new TopTenUsers
                            {                               
                                Surname = reader.GetString("Surname"),
                                Name = reader.GetString("Name"),
                                Patronymic = reader.GetString("Patronymic"),
                                Section = reader.GetString("Section")
                            });
                        await reader.CloseAsync();
                    }                  
                    finally
                    {
                        await connection.CloseAsync();
                    }
                }
            }

            return topTenUsers;
        }

        public class TopTenUsers
        {           
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Patronymic { get; set; }
            public string Section { get; set; }
        }
    }
}
