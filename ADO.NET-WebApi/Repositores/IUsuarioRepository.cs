using ADO.NET_WebApi.Models;
using System.Collections.Generic;

namespace ADO.NET_WebApi.Repositores
{
    interface IUsuarioRepository
    {
        public List<Usuario> Get();

        public Usuario Get(int id);

        public void Insert(Usuario usuario);

        public void Update(Usuario usuario);

        public void Delete(int id);


    }
}
