using SimpleGrapeCity.Data;
using SimpleGrapeCity.Models;
using SimpleGrapeCity.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleGrapeCity.Repository
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        private readonly ApplicationDbContext _db;
        public MemberRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Update(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
