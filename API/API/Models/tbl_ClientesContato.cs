using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class tbl_ClientesContato
    {
        public int CodContato { get; set; }
        public int? CodCliente { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string TipoContato { get; set; }
        public int? idTipoContato { get; set; }
        public bool? FlgAssinaPDF { get; set; }
        public string MetodoAutenticacao { get; set; }
        public bool? FlgEmailPara { get; set; }

        public virtual tbl_Cliente CodClienteNavigation { get; set; }
        public virtual tbl_TipoContato idTipoContatoNavigation { get; set; }
    }
}
