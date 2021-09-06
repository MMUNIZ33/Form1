using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class tbl_Cliente
    {
        public tbl_Cliente()
        {
            tbl_ClientesContatos = new HashSet<tbl_ClientesContato>();
        }

        public int CodCliente { get; set; }
        public string DesCliente { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string IM { get; set; }
        public string Suframa { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Contato { get; set; }
        public decimal? VlrDesconto { get; set; }
        public DateTime? DatCadastro { get; set; }
        public string NomUsuario { get; set; }
        public string RG { get; set; }
        public string CNH { get; set; }
        public DateTime? CNHValidade { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Contato2 { get; set; }
        public string Contato3 { get; set; }
        public int? CodPrazoPagamento { get; set; }
        public int? CodFormaPagamento { get; set; }
        public bool? FlgLiberado { get; set; }
        public DateTime? DatLiberado { get; set; }
        public string NomUsuarioLiberado { get; set; }
        public int? CodVendedor { get; set; }
        public string EnderecoComplemento { get; set; }
        public int? FlgNegativado { get; set; }
        public int? CodSituacaoCadastral { get; set; }

        public virtual ICollection<tbl_ClientesContato> tbl_ClientesContatos { get; set; }
    }
}
