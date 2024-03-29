﻿using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using RestApi_CleanArchitecture.App.IServices;
using RestApi_CleanArchitecture.App.Mapping.Model;
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
        private readonly IMapper _mapper;
        public ControllerUsers(
            ICreateService RepSave,
            IUpdateService RepUpdate,
            IDeleteService RepDelete,
            IGetService RepGet,
            IGetByIdService RepGetById,
            IMapper mapper
            )
        {
            _RepSave = RepSave;
            _RepUpdate = RepUpdate;
            _RepDelete = RepDelete;
            _RepGet = RepGet;
            _RepGetById = RepGetById;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(InputModelUser user)
        {
            try
            {
                var mapp = _mapper.Map<User>(user);

                var register = _RepSave.Save(mapp);

                return CreatedAtAction(nameof(GetById), new { id = mapp.Id }, mapp);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { errors = ex.Errors.Select(e => e.ErrorMessage) });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro de criação por parte do servidor(Controller): {ex.Message}");
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, User user)
        {
            try
            {
                _RepUpdate.Update(id, user);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro de atuaização por parte do servidor(Controller): {ex.Message}");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _RepDelete.Delete(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro de exclusão por parte do servidor(Controller): {ex.Message}");
            }
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var registers = _RepGet.FindAll();

                var mapp = _mapper.Map<List<ViewModelUser>>(registers);

                return Ok(mapp);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Erro de busca por parte do servidor(Controller): {ex.Message}");
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                var registerId = _RepGetById.FindById(id);

                return Ok(registerId);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Erro de busca por parte do servidor(Controller): {ex.Message}");
            }
        }
    }
}
