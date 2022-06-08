using Microsoft.EntityFrameworkCore;
using MonProjetdotNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Data.Services
{
    public class ParfumService : IParfumsService
    {
        private readonly AppDbContext _context;

        public ParfumService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Parfum parfum)
        {
            await _context.Parfums.AddAsync(parfum);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Parfums.FirstOrDefaultAsync(n => n.Id == id);
            _context.Parfums.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Parfum>> GetAllAsync()
        {
            var result = await _context.Parfums.ToListAsync();
            return (result);
        }

        public async Task <Parfum>GetByIdAsync(int id)
        {
            var result = await _context.Parfums.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task< Parfum> UpdateAsync(int id, Parfum newparfum)
        {
            _context.Update(newparfum);
            await _context.SaveChangesAsync();
            return newparfum;
        }

    }
}
