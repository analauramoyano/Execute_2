﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Execute_2.EE;
using Execute_2.Utilities;

namespace Execute_2.DAL
{
    public class DAO : IDAO
    {
        

        public void Alta(Genero entidad)
        {
            throw new NotImplementedException();
        }

        public void Baja(Genero entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genero> Listar()
        {
            string query = "Select * from " + CrearTabla<Genero>();
            var devolver = EjecutarQuery.ExecuteSelectStatement<Genero>(query);
            return devolver;         
        }

        private string CrearTabla<T>()
        {
            return typeof(T).Name;
        }

        public void Modificacion(Genero entidad)
        {
            throw new NotImplementedException();
        }
    }
}