﻿using SallyPieShop.Models;

namespace SallyPieShop.Data
{
    public class PieRepository :IPieRepository
    {

        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
           
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _appDbContext.Pies;
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _appDbContext.Pies.Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
