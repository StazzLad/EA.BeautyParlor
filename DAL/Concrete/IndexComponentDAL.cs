using EA.DAL.Abstract;
using EA.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Concrete
{
    public class IndexComponentDAL : IIndexComponentDAL
    {
        private readonly BPContext _context;
        public IndexComponentDAL()
        {
            _context = new BPContext();
        }
      
        public int Add(IndexComponent IndexComponent)
        {
            _context.IndexComponents.Add(IndexComponent);
            return _context.SaveChanges();
        }

        public int Delete(Guid id)
        {
            _context.IndexComponents.Remove(_context.IndexComponents.Find(id));
            return _context.SaveChanges();
        }

        public async Task<List<IndexComponent>> GetActiveComponents()
        {
            return await _context.IndexComponents
                .Where(x => x.Status == 1)
                .ToListAsync();
        }
        public bool IsActive(Guid id)
        {
            return _context.IndexComponents
                .Any(x => x.Id == id && x.Status == 1);
        }

        public async Task<IndexComponent> GetByIdAsync(Guid id)
        {
            return await _context.IndexComponents.FindAsync(id);
        }

        public IndexComponent? GetById(Guid id)
        {
            return _context.IndexComponents.Find(id);
        }

        public int Update(IndexComponent indexComponent)
        {
            _context.IndexComponents.Update(indexComponent);
            return _context.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var modifiedEntires = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && x.State is EntityState.Added or EntityState.Modified or EntityState.Deleted);

            foreach (var entire in modifiedEntires)
            {
                var entity = entire.Entity as BaseEntity;

                switch (entire.State)
                {
                    case EntityState.Modified:
                        entity.UpdatedAt = DateTime.Now;
                        
                        break;
                    case EntityState.Added:
                        entity.Status = 1;
                        entity.CreatedAt = DateTime.Now;
                        entity.UpdatedAt = DateTime.Now;
                        entity.Id = Guid.NewGuid();
                        break;
                }
            }
        }
    }
}
