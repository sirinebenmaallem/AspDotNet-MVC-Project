using MonProjetdotNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Data.Services
{
    public interface IParfumsService
    {
        Task<IEnumerable<Parfum>> GetAllAsync();

        Task <Parfum> GetByIdAsync(int id);

        Task AddAsync(Parfum parfum);

        Task<Parfum> UpdateAsync(int id, Parfum parfum);

        Task DeleteAsync(int id);
    }
}
