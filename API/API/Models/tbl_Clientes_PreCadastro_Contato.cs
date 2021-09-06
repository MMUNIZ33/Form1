using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class tbl_Clientes_PreCadastro_Contato
    {
        public int CodContatoPre { get; set; }
        public int? CodClientePre { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int? idTipoContato { get; set; }
        public bool? FlgAssinaPDF { get; set; }

        public virtual tbl_Clientes_PreCadastro CodClientePreNavigation { get; set; }
        public virtual tbl_TipoContato idTipoContatoNavigation { get; set; }

        public tbl_Clientes_PreCadastro_Contato()
        {

        }
    }
}
