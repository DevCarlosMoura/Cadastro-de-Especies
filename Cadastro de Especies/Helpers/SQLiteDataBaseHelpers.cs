using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using Cadastro_de_Especies.Models;

namespace Cadastro_de_Especies.Helpers
{
    public class SQLiteDataBaseHelpers
    {
            readonly SQLiteAsyncConnection _conn;

            public SQLiteDataBaseHelpers(string path) 
            {
                _conn = new SQLiteAsyncConnection(path);
                _conn.CreateTableAsync<Especie>().Wait();
            }
            public void Insert() { }
            public void Update() { } 
            public void Delete() { }
            public void GetAll() { }
            public void Search() { }
        
    }
}
