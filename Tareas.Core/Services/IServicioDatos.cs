using System.Threading.Tasks;
using DataModel.ViewModel;

namespace Tareas.Core.Services
{
    public interface IServicioDatos
    {

        #region Usuario

        Task<UsuarioModel> Validar(UsuarioModel model);

        #endregion

    }
}