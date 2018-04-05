//"Exercícios Aula 6 | Kayo Gamas | 601298 | 26/03/2018 \n\n"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_17_LABAED_LISTAS_AULA06
{
    class Program
    {
         static void Main(string[] args)
        {

            Console.WriteLine("Exercícios Aula 6 | Kayo Gamas | 601298 | 26/03/2018 \n\n");
       
            ListaEleitores list = new ListaEleitores();
            list.CarregarEmOrdem(@"../../Dados.csv");
            Console.WriteLine("Quantidade de Eleitores da lista principal: {0}\n", list.Count);
            Console.WriteLine("Todos os Eleitores em Ordem\n");
            Console.WriteLine(list.ToString());

            Eleitor lixo = list.Eliminar("25078437206"); //Remove a Breanna I. Mendoza-M-25078437206-24-14
            Console.WriteLine("Removir a Breanna I. Mendoza-M-25078437206-24-14");
            Console.WriteLine("Quantidade de Eleitores da lista principal: {0}\n", list.Count);
            Console.WriteLine(list.ToString());

            ListaEleitores list2 = new ListaEleitores();
            string[] auxVertor = { "24", "23", "38", "35", "29", "29" };
            for (int i = 0; i < auxVertor.Length - 1; i += 2)
            {
                list2.Concat(list.EleitoresSecao(auxVertor[i], auxVertor[i + 1]));
            }
            Console.WriteLine("Removir os Eleitores das Zonas e Seções {0}-{1} {2}-{3} {4}-{5}", "24", "23", "38", "35", "29", "29");
            Console.WriteLine("Quantidade de Eleitores {0}\n", list2.Count);
            Console.WriteLine(list2.ToString());

            ListaEleitores list3 = new ListaEleitores();
            list3 = list.ListaPorSexo('M'); 
            Console.WriteLine("Lista de Homens");
            Console.WriteLine("Quantidade de Eleitores: {0}\n", list3.Count);
            Console.WriteLine(list3.ToString());

            ListaEleitores list4 = new ListaEleitores();
            list4 = list.ListaPorSexo('F');
            Console.WriteLine("Lista de Mulheres");
            Console.WriteLine("Quantidade de Eleitores: {0}\n", list4.Count);
            Console.WriteLine(list4.ToString());


            Console.WriteLine("Quantidade de Eleitores da lista principal: {0}\n", list.Count);
            Console.WriteLine("Todos os Eleitores em Ordem\n");
            Console.WriteLine(list.ToString());

            list.Concat(list2);
            list.Concat(list3);
            list.Concat(list4);
            Console.WriteLine("Contatenei todas as lista na lista principal(Obs. Não tem a Breanna I. Mendoza-M-25078437206-24-14)\n");
            Console.WriteLine("Quantidade de Eleitores da lista principal: {0}\n", list.Count);
            Console.WriteLine("Todos os Eleitores na lista principal concatenada\n");
            Console.WriteLine(list.ToString());

            list.AddStart(lixo);
            Console.WriteLine("Adicionei a \"Breanna I.Mendoza - M - 25078437206 - 24 - 14\" no ínicio da lista principal\n");
            Console.WriteLine("Quantidade de Eleitores da lista principal: {0}\n", list.Count);
            Console.WriteLine("Todos os Eleitores na lista principal\n");
            Console.WriteLine(list.ToString());

            list.EliminarElementosPosicoesPares();
            Console.WriteLine("Quantidade de Eleitores da lista principal após remover elementos na posições pares: {0}\n", list.Count);
            Console.WriteLine("Os Eleitores \n");
            Console.WriteLine(list.ToString());

            Console.ReadKey();
            
        }
    }
}
