﻿using System;
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
            public Task<int> Insert(Especie p)
            {
                _conn.InsertAsync(p);
            }
            public Task<List<Especie>> Update(Especie p) 
            {
                string sql = "UPDATE Especie SET Nome=? WHERE Codigo=?";
                _conn.QueryAsync<Especie>(sql, p.Nome, p.Codigo);
            } 
            public void Delete(Especie p) 
            {
                _conn.Table<Especie>().DeleteAsync(i => i.Codigo == P);

                /*
                string sql = "DELETE Especie WHERE Codigo=?";
                _conn.QueryAsync<Especi>(sql, p);
                */
            }
            public Task<List<Especie>> GetAll() 
            {
                 return _conn.Table<Especie>().ToListAsync();
   
            }
            public void Search(string p) 
            {
                string sql = "SELECT * FROM Especie WHERE Nome LIKE %'" + p + "'%";
                return _conn.QueryAsync<Especie>(sql);
            }
        
    }
}
