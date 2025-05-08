using EA.DAL.Abstract;
using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Concrete
{
    public class ServicesComponentDAL : IServicesComponentDAL
    {
        private readonly BPContext _context;
        public ServicesComponentDAL()
        {
            _context = new BPContext();
        }
        public int Add(ServicesComponent servicesComponent)
        {
            _context.ServicesComponents.Add(servicesComponent);
            return _context.SaveChanges();
        }

        public int Delete(Guid id)
        {
            _context.ServicesComponents.Remove(_context.ServicesComponents.Find(id));
            return _context.SaveChanges();
        }

        public ServicesComponent? GetById(Guid id)
        {
            return _context.ServicesComponents.Find(id);
        }

        public int Update(ServicesComponent servicesComponent)
        {
            _context.ServicesComponents.Update(servicesComponent);
            return _context.SaveChanges();
        }
    }
}
