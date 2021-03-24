using SimpleGrapeCity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleGrapeCity.Repository.IRepository
{
    public interface IMemberRepository : IRepository<Member>
    {
        void Update(Member member);
    }
}
