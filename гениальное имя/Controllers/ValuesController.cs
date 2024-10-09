using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using гениальное_имя.Model;

namespace гениальное_имя.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDataController : ControllerBase
    {
        readonly DB.DB database;
        public PersonalDataController(DB.DB database)
        {

            this.database = database;
        }
        [HttpPost]
        public async void CreatePassport(Passport passport)
        {
            database.Passports.Add(passport);
            await database.SaveChangesAsync();

        }
    }
}
