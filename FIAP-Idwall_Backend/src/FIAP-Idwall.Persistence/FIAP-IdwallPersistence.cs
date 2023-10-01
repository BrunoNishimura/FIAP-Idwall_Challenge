using FIAP_Idwall.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Idwall.Persistence
{
    internal class FIAP_IdwallPersistence : I_FIAP_IdwallPersistence
    {

        //Construtor
        private readonly FIAP_IdwallContext _context;
        
        public FIAP_IdwallPersistence(FIAP_IdwallContext context)
        {
            _context = context;
        }
        
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        //public void DeleteRange<T>(T[] entityArray) where T : class
        //{
        //    _context.RemoveRange(entityArray);
        //}


        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        //Interpoll | FBI
        //public Task<ModelInterpol[]> GetAllInterpolByNameAsync(string InterpolFullname, bool includeFbi)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<ModelInterpol[]> GetAllInterpolAsync(bool includeFbi = false)
        //{
        //    IQueryable<ModelInterpol> query = _context.ModelInterpols;
        //}

        //public Task<ModelInterpol[]> GetInterpolByIdAsync(int InterpolId, bool includeFbi)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ModelInterpol[]> GetAllFbiByNameAsync(string InterpolFullname, bool includeInterpol)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ModelInterpol[]> GetAllFbiAsync(bool includeInterpol)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ModelInterpol[]> GetFbiByIdAsync(int InterpolId, bool includeInterpol)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
