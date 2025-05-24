using EA.BLL.Abstract;
using EA.DAL.Abstract;
using EA.DAL.Concrete;
using EA.Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EA.BLL.Concrete
{
    public class IndexComponentBLL : IIndexComponentBLL
    {
        private readonly IIndexComponentDAL _dal;



        public IndexComponentBLL()
        {
            _dal = new IndexComponentDAL();
        }
        public async Task<List<IndexComponent>> GetActiveComponents()
        {
            return await _dal.GetActiveComponents();
        }
        public async Task<List<IndexComponent>> GetById()
        {
            return await _dal.GetActiveComponents();
        }
        public IActionResult SetActiveImage(Guid id)
        {
            var image = _dal.GetById(id);
            if (image != null)
            {
                foreach (var img in _dal.GetActiveComponents().Result)
                {
                    img.IsActive = false;
                    _dal.Update(img);
                }
                image.IsActive = true;
                _dal.Update(image);
            }
            return null;
        }

        public bool Add(IndexComponent indexComponent)
        {
            try
            {
                int result = _dal.Add(indexComponent);
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Delete(Guid id)
        {
            try
            {
                int result = _dal.Delete(id);
                if (result > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IndexComponent? Get(Guid id)
        {
            try
            {
                return _dal.GetById(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(IndexComponent indexComponent)
        {
            try
            {
                int result = _dal.Update(indexComponent);
                if (result > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsActive(Guid id)
        {
            throw new NotImplementedException();
        }
        public IndexComponent? GetbyAsync(Guid id)
        {
            try
            {
                return _dal.GetById(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        }
    }
