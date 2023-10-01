using FIAP_Idwall.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Idwall.Persistence
{
    public interface I_FIAP_IdwallPersistence
    {
        //Tabela
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;

        //void DeleteRange<T>(T[] entity) where T: class;

        Task<bool> SaveChangesAsync();

        //Interpol
        //Task<ModelInterpol[]> GetAllInterpolByNameAsync(string InterpolFullname, bool includeFbi);
        //Task<ModelInterpol[]> GetAllInterpolAsync(bool includeFbi);
        //Task<ModelInterpol[]> GetInterpolByIdAsync(int InterpolId, bool includeFbi);

        ////FBI
        //Task<ModelInterpol[]> GetAllFbiByNameAsync(string InterpolFullname, bool includeInterpol);
        //Task<ModelInterpol[]> GetAllFbiAsync(bool includeInterpol);
        //Task<ModelInterpol[]> GetFbiByIdAsync(int InterpolId, bool includeInterpol);
    }
}
