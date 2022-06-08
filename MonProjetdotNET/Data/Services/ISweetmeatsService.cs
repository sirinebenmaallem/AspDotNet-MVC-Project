using MonProjetdotNET.Data.Base;
using MonProjetdotNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Data.Services
{
    public interface ISweetmeatsService
    {
        Task <IEnumerable<Sweetmeat>> GetAll();

        Task<Sweetmeat> GetByIdAsync(int id);

        Task AddAsync(Sweetmeat sweetmeat);

        Task<Sweetmeat>  UpdateAsync(int id, Sweetmeat sweetmeat);

        Task DeleteAsync(int id);
    }
}
