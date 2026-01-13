using SallyPieShop.Models;

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
                return _appDbContext.Pie;
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _appDbContext.Pie.Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pie.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
