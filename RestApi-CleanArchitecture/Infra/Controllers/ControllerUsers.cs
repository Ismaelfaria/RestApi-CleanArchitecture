using Microsoft.AspNetCore.Mvc;
using RestApi_CleanArchitecture.App.IServices;
using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.Infra.Controllers
{
    [Route("api/UsersOperations")]
    [ApiController]
    public class ControllerUsers : ControllerBase
    {
        private readonly ICreateService _RepSave;
        private readonly IUpdateService _RepUpdate;
        private readonly IDeleteService _RepDelete;
        private readonly IGetService _RepGet;
        private readonly IGetByIdService _RepGetById;
        public ControllerUsers(
            ICreateService RepSave,
            IUpdateService RepUpdate,
            IDeleteService RepDelete,
            IGetService RepGet,
            IGetByIdService RepGetById
            )
        {
            _RepSave = RepSave;
            _RepUpdate = RepUpdate;
            _RepDelete = RepDelete;
            _RepGet = RepGet;
            _RepGetById = RepGetById;
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
            _RepSave.Save(user);

            return Created();
        } 
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, User user)
        {
            _RepUpdate.Update(id, user);

            return NoContent();
        } 
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _RepDelete.Delete(id);

            return NoContent();
        } 
        [HttpGet]
        public IActionResult GetAll()
        {
            _RepGet.FindAll();

            return Ok();
        } 
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
              _RepGetById.FindById(id);

            return Ok();
        }
    }
}
