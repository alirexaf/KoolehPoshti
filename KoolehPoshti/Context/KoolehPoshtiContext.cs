using Microsoft.EntityFrameworkCore;

namespace KoolehPoshti.Context
{
    public class KoolehPoshtiContext : DbContext
    {
        public KoolehPoshtiContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
                
        }
    }
}
