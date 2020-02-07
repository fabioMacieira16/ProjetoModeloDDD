using System;

namespace ProjetoModeloDDD.domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public bool ClienteEspecial(Cliente cliente) 
        {
            //verifica se o cliente esta ativo e se tem mais de 5 anos de cadastro
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
