using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleGrapeCity.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IMemberRepository Member { get; }    
        ISP_Call SP_Call { get; } 
        void Save();
    }
}
