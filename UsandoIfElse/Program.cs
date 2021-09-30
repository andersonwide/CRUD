
using PrecisoQueEsseFunfe;
using System;
using System.Collections.Generic;

namespace usandoIfElse
{
    class Program
    {
        static List<Ob> listaOb = new List<Ob>();
        static void Main(string[] args)
        {
            string entrada = "";
            Console.WriteLine("Hello World!");
            while (entrada != "SAIR")
            {
                Console.WriteLine("Deseja adicionar, atualizar, deletar, listar registros ou sair?");
                entrada = Console.ReadLine().ToUpper();
                if (entrada == "ADICIONAR")
                {
                    Adicionar();
                }
                else if (entrada == "ATUALIZAR")
                {
                    Atualizar();
                }
                else if (entrada == "DELETAR")
                {
                    Deletar();
                }
                else if (entrada == "LISTAR")
                {
                    Listar();
                }
                else if (entrada == "SAIR")
                {
                    Console.WriteLine("Obrigado por usar nossos serviços, volte sempre.");
                }
            }
        }
        private static void Adicionar()
        {
            Console.WriteLine("Digite o nome:");
            string entradaNome = Console.ReadLine();
            Console.WriteLine("Digite seu identificador:");
            string entradaId = Console.ReadLine();
            Ob novoOb = new Ob(entradaNome, entradaId);
            listaOb.Add(novoOb);
            Console.WriteLine("Nome salvo");
        }
        private static void Atualizar()
        {
            Console.WriteLine("Escolha o ID do nome a ser atualizado:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo nome:");
            string novoNome = Console.ReadLine();
            Console.WriteLine("Digite o novo ID");
            string entradaNovoId = Console.ReadLine();
            listaOb[id] = new Ob(novoNome, entradaNovoId);
            Console.WriteLine("Nome atualizado com sucesso!");
        }
        private static void Deletar()
        {
            if (listaOb.Count == 0)
            {
                Console.WriteLine("Não há registros salvos");
                return;
            }
            else
            {
                Console.WriteLine("Selecione o ID do registro a ser deletado");
                int idDeletar = int.Parse(Console.ReadLine());
                listaOb.RemoveAt(idDeletar);
                Console.WriteLine("Registro deletado com sucesso");
            }
        }
        private static void Listar()
        {
            if (listaOb.Count == 0)
            {
                Console.WriteLine("Não há nomes salvos");
                return;
            }
            for (int i = 0; i < listaOb.Count; i++)
            {
                Ob ob = listaOb[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(" Nome: {0} ID: {1}", ob.Nome, ob.Id);
            }
        }
    }

}
