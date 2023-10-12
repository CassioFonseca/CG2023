using CGEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetTesteX
    {
        public int Id { get; set; }
        public string Descricao {  get; set; }
        public ICollection<DbSetSubCategoria>? Subcategoriasx { get; set; }
    }
}
