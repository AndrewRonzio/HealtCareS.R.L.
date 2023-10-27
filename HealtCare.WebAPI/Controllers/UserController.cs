using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using HealtCare.DAL.GenericClass;
using HealtCare.DAL.Data;
using HealtCare.WebAPI.Models;

namespace HealtCare.WebAPI.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _repo;
        private readonly Mapper _mapper;



        public UserController(IUnitOfWork repo, Mapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }



        [HttpGet]
        [Route("GetSingle/{id}")]
        public async Task<IActionResult> GetSingle(string Id)
        {
            User user = _repo.UserRepository.Get(Id);

            return user != null ? Ok(_mapper.MapEntityToModel(user)) : NotFound();
        }


        [HttpGet]
        [Route("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            List<User> users = _repo.UserRepository.GetAll();
            List<UserModel> models = new List<UserModel>();

            users.ForEach(user => { models.Add(_mapper.MapEntityToModel(user)); });
            return Ok(users);
        }



        [HttpPost]
        [Route("Register/{UserModel}")]
        public async Task<IActionResult> Register([FromBody] UserModel UserModel)
        {
            List<User> users = _repo.UserRepository.GetAll();

            if (users.Any(x => x.Email == UserModel.Email))
                return BadRequest("Errore, Utente con questa mail già registrato");

            User user = new User
            {
                UserName = UserModel.Name,
                Surname = UserModel.Surname,
            }

            _repo.UserRepository.Create()

        }


    }
}
