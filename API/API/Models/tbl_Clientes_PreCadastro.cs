using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class tbl_Clientes_PreCadastro
    {
        public tbl_Clientes_PreCadastro()
        {
            tbl_Clientes_PreCadastro_Contatos = new HashSet<tbl_Clientes_PreCadastro_Contato>();
        }

        public int CodClientePre { get; set; }
        public string DesCliente { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string IE { get; set; }
        public string IM { get; set; }
        public string Suframa { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Contato { get; set; }
        public DateTime? DatCadastro { get; set; }
        public string NomUsuario { get; set; }

        public virtual ICollection<tbl_Clientes_PreCadastro_Contato> tbl_Clientes_PreCadastro_Contatos { get; set; }
    }
}
