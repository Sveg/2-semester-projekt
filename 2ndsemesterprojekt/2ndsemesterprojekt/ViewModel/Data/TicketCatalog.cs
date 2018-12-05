using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace _2ndsemesterprojekt
{
    public class TicketCatalog : Connection<Ticket>
    {
        //public override List<Ticket> BuildObjects(DbSet<Ticket> objects)
        //{
        //    return objects.ToList();
        //}
    }
}