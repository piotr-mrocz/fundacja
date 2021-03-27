using AutoMapper;
using FundacjaZawszeRazem.Data;
using FundacjaZawszeRazem.DTOs;
using FundacjaZawszeRazem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.Controllers
{
    [Route("api/[controller]")] // localhost/api/foundhome
    public class FoundHomeController : ControllerBase
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public FoundHomeController(DataContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        // See all adopted pets
        [HttpGet]
        public async Task<IActionResult> GetPets()
        {
            var home = await context.Homes.ToListAsync();
            var homeToReturn = mapper.Map<List<FoundHomeListDTO>>(home);
            return Ok(homeToReturn);
        }

        // See one adopted pet
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPet(int id)
        {
            var home = await context.Homes.FirstOrDefaultAsync(p => p.Id == id);

            if (home == null)
            {
                return NotFound();
            }

            var homeToReturn = mapper.Map<FoundHomeDetailsDTO>(home);
            return Ok(homeToReturn);
        }

        // Add adopted pet
        [HttpPost]
        public async Task<IActionResult> AddNewAdoptedPet([FromBody] FoundHomeToAddDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var home = mapper.Map<FoundHome>(model);
                await context.Homes.AddAsync(home);
                await context.SaveChangesAsync();
                return NoContent();
            }
        }

        // Editadopted pet
        [HttpPut("{id}")]
        public async Task<IActionResult> EditAdoptedPet(int id, [FromBody] FoundHomeToUpdateDTO model)
        {
            var home = await context.Homes.FirstOrDefaultAsync(p => p.Id == id);

            if (home == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            home.Adopted = model.Adopted;
            home.Photo = model.Photo;

            await context.SaveChangesAsync();
            return NoContent();
        }


        // Remove adopted pet
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdoptedPet(int id)
        {
            var petToDelete = await context.Homes.FirstOrDefaultAsync(p => p.Id == id);
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
