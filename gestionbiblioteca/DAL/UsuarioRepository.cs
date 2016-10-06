using gestionbiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionbiblioteca.DAL
{
    interface UsuarioRepository
    {
        IList<Usuario> getAll();
        Usuario getById(Guid codigo);

        Usuario update(Usuario usuario);

        void delete(Guid codig);

        int create(Usuario usuario);

    }
}
