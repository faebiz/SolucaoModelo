using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.ORM.BASE;

namespace Modelo.ORM.INFO {
    public class CategoriaInfo : BaseInfo {
        public int CategoriaID { get; set; }
        public string Descricao { get; set; }
        public bool IsAtivo { get; set; }

        public string DescPadrao { get { return Descricao; } }
    }
}
