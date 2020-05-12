using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sisvix.Manicure.Repository
{
    public class RepositoryConnector
    {

        public IConfiguration _iconfiguration;

        public RepositoryConnector(IConfiguration _iconfiguration)
        {
            this._iconfiguration = _iconfiguration;
        }

        public string GetConnection()
        {
            return _iconfiguration.GetSection("").GetSection("").Value;
        }
    }
}
