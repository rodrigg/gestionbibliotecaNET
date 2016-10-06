using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gestionbiblioteca.Models;
using System.Configuration;

namespace gestionbiblioteca.DAL
{
    public class UsuarioRepositoryImp : UsuarioRepository
    {   private  string= ConfigurationManager.ConnectionStrings["biblioteca"].ConnectionString;
        public int create(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void delete(Guid codig)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> getAll()
        {
            throw new NotImplementedException();
        }

        public Usuario getById(Guid codigo)
        {   Usuario usuario=null;
            const string SQL ="";
            using(SqlConnection conexion=new SqlConnection())
            return usuario;
        }

        public Usuario update(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}