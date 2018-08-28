using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemploSolution.AplicationCore.Entity;

namespace ExemploSolution.Infrastructure.Data
{
    public static class DBInitializer
    {
        public static void Initialize(AplicationDBCotnext contex)
        {
            if (contex.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Marcelo Ribeiro Braga",
                    Cpf = "06328682603",
                    Telefone = "37998031211",
                    DataCadastro = Convert.ToDateTime("28/08/2018"),
                },
                new Cliente
                {
                    Nome = "Henrique Braga Neto",
                    Cpf = "13418866620",
                    Telefone = "37999062141",
                    DataCadastro = Convert.ToDateTime("28/08/2018"),
                },
            };
            contex.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Marcelo Ribeiro Braga",
                    Telefone = "37998031211",
                    Email = "marcelosbraga@gmail.com",
                    Cliente = clientes[0],
                },
                new Contato()
                {
                    Nome = "Henrique Braga Neto",
                    Telefone = "37999062141",
                    Email = ("hbraganeto@gmail.com"),
                    Cliente = clientes[1],

                },
            };
            contex.AddRange(contatos);
            contex.SaveChanges();
        }
    }
}
