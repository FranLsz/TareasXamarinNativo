using System.Threading.Tasks;
using DataModel.ViewModel;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using Tareas.Core.Utils;

namespace Tareas.Core.Services
{
    public class ServicioDatos : IServicioDatos
    {
        private readonly RestClient _client;

        public ServicioDatos()
        {
            _client = new RestClient(GlobalVars.UrlApi);
        }


        #region Usuario

        public async Task<UsuarioModel> Validar(UsuarioModel model)
        {
            var request = new RestRequest("Usuario") { Method = Method.GET };
            request.AddQueryParameter("email", model.Email);
            request.AddQueryParameter("password", model.Password);

            // la api devuelve error 404 si no existe, y restsharp peta
            var response = await _client.Execute<UsuarioModel>(request);
            if (response.IsSuccess)
                return response.Data;

            return null;

        }

        #endregion
    }
}