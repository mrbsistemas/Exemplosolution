using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ExemploSolution.AplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {
                
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public  string Telefone { get; set; }
        public ICollection<Contato> Contatos { get; set; }


    }


}
