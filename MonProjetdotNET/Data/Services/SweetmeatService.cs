using Microsoft.EntityFrameworkCore;
using MonProjetdotNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Data.Services
{
    public class SweetmeatService : ISweetmeatsService
    {

        private readonly AppDbContext _context;
        public SweetmeatService(AppDbContext context)
        {
            _context = context;


        }

        public async Task AddAsync(Sweetmeat sweetmeat)
        {
            await _context.Sweetmeats.AddAsync(sweetmeat);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Sweetmeats.FirstOrDefaultAsync(n => n.Id == id);
            _context.Sweetmeats.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Sweetmeat>> GetAll()
        {
            var result=await _context.Sweetmeats.ToListAsync();
            return result;
        }

        public async Task<Sweetmeat> GetByIdAsync(int id)
        {
            var result = await _context.Sweetmeats.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Sweetmeat>  UpdateAsync(int id, Sweetmeat sweetmeat)
        {
            _context.Update(sweetmeat);
            await _context.SaveChangesAsync();
            return sweetmeat;
        }

        
    }
}
