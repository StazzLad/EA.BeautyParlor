using EA.DAL.Abstract;
using EA.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Concrete
{
    public class AboutPageComponentDAL : IAboutPageComponentDAL
    {
        private readonly BPContext _context;
        public AboutPageComponentDAL()
        {
            _context = new BPContext();
        }

        public int Add(AboutPageComponent aboutPageComponent)
        {
            _context.AboutPageComponents.Add(aboutPageComponent);
            return _context.SaveChanges();
        }

        public int Delete(Guid id)
        {
            _context.AboutPageComponents.Remove(_context.AboutPageComponents.Find(id));
            return _context.SaveChanges();
        }

        public AboutPageComponent? GetById(Guid id)
        {
            return _context.AboutPageComponents.Find(id);
        }

        public int Update(AboutPageComponent aboutPageComponent)
        {
            _context.AboutPageComponents.Update(aboutPageComponent);
            return _context.SaveChanges();
        }
    }
}
