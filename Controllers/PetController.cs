using AutoMapper;
using FundacjaZawszeRazem.Data;
using FundacjaZawszeRazem.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly DataContext context;
        public PetController(IMapper _mapper, DataContext _context)
        {
            mapper = _mapper;
            context = _context;
        }

        // See all pets
        [HttpGet]
        public async Task<IActionResult> GetPets()
        {
            var pets = await context.Pets.ToListAsync();
            var petsToReturn = mapper.Map<List<PetsListDTO>>(pets);
            return Ok(petsToReturn);
        }


        // Get one pet
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPet(int id)
        {
            var pet = await context.Pets.FirstOrDefaultAsync(p => p.Id == id);

            if (pet == null)
            {
                return NotFound();
            }

            var petToReturn = mapper.Map<PetDetailsDTO>(pet);
            return Ok(petToReturn);
        }


        // Add new pet
        [HttpPost]
        public async Task<IActionResult> AddNewPet([FromBody] PetToAddDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var pet = mapper.Map<Pet>(model);
                await context.Pets.AddAsync(pet);
                await context.SaveChangesAsync();
                return NoContent();
            }
        }


        // Edit pet
        [HttpPut("{id}")]
        public async Task<IActionResult> EditPet(int id, [FromBody] PetToUpdateDTO model)
        {
            var pet = await context.Pets.FirstOrDefaultAsync(p => p.Id == id);

            if (pet == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            pet.Description = model.Description;
            pet.Photo = model.Photo;

            await context.SaveChangesAsync();
            return NoContent();
        }

        
        // Delete pet
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePet(int id)
        {
            var petToDelete = await context.Pets.FirstOrDefaultAsync(p => p.Id == id);
            if (petToDelete == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(petToDelete);
                await context.SaveChangesAsync();
                return NoContent();
            }
        }
    }
}
