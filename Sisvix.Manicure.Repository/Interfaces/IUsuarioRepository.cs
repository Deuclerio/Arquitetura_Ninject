using Sisvix.Manicure.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sisvix.Manicure.Repository.Interfaces
{
    public  interface IUsuarioRepository
    {
        Usuario Get(string email, string senha);
        Usuario Get(string email);
    }
}
