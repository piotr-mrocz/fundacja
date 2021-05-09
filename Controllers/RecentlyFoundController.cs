using AutoMapper;
using FundacjaZawszeRazem.Data;
using FundacjaZawszeRazem.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace FundacjaZawszeRazem.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // localhost/api/recentlyfound
    public class RecentlyFoundController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly DataContext context;
        public RecentlyFoundController(IMapper _mapper, DataContext _context)
        {
            mapper = _mapper;
            context = _context;
        }


        // See all found pets
        [HttpGet]
        public async Task<IActionResult> GetPets()
        {
            var pets = await context.Found.ToListAsync();
            var petsToReturn = mapper.Map<List<RecentlyFoundListDTO>>(pets);
            return Ok(petsToReturn);
        }


        // See one found pet
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPet(int id)
        {
            var pet = await context.Found.FirstOrDefaultAsync(p => p.Id == id);

            if(pet == null)
            {
                return NotFound();
            }
            
            var petToReturn = mapper.Map<RecentlyFoundDetailsDTO>(pet);
            return Ok(petToReturn);
        }

        
        // Add new found pet
        [HttpPost]
        public async Task<IActionResult> AddNewFoundPet([FromBody] RecentlyFoundToAddDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var pet = mapper.Map<RecentlyFound>(model);
                await context.Found.AddAsync(pet);
                await context.SaveChangesAsync();
                return NoContent();
            }
        }


        // Edit found pet
        [HttpPut("{id}")]
        public async Task<IActionResult> EditFoundPet(int id, [FromBody] RecentlyFoundToUpdateDTO model)
        {
            var pet = await context.Found.FirstOrDefaultAsync(p => p.Id == id);

            if (pet == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            pet.Chip = model.Chip;
            pet.ChipSequence = model.ChipSequence;
            pet.DateFound = model.DateFound; 
            pet.Description = model.Description;
            pet.PlaceFound = model.PlaceFound;
            pet.Photo = model.Photo;

            await context.SaveChangesAsync();
            return NoContent();
        }

        
        // Remove found pet
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdoptedPet(int id)
        {
            var petToDelete = await context.Found.FirstOrDefaultAsync(p => p.Id == id);
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
