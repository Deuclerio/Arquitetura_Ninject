using Sisvix.Manicure.Domain.Entitys;
using Sisvix.Manicure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sisvix.Manicure.Repository.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario Get(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Usuario Get(string email)
        {
            throw new NotImplementedException();
        }
    }
}
