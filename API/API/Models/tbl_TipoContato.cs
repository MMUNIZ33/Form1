using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class tbl_TipoContato
    {
        public tbl_TipoContato()
        {
            tbl_ClientesContatos = new HashSet<tbl_ClientesContato>();
            tbl_Clientes_PreCadastro_Contatos = new HashSet<tbl_Clientes_PreCadastro_Contato>();
        }

        public int idTipoContato { get; set; }
        public string DesTipoContato { get; set; }

        public virtual ICollection<tbl_ClientesContato> tbl_ClientesContatos { get; set; }
        public virtual ICollection<tbl_Clientes_PreCadastro_Contato> tbl_Clientes_PreCadastro_Contatos { get; set; }
    }
}
