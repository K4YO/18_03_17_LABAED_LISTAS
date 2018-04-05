//"Exercícios Aula 6 | Kayo Gamas | 601298 | 26/03/2018 \n\n"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLibrary;
using System.IO;
namespace _18_03_17_LABAED_LISTAS_AULA06
{
    class ListaEleitores : List
    {
        /// <summary>
        /// Inicializa uma nova instância de lista duplamente encadeada para Eleitores que está vazia e tem a capacidade inicial padrão
        /// </summary>
        public ListaEleitores() : base()   {}

        public Eleitor Eliminar(string titulo)
        {
            return (Eleitor)base.Remove(new Eleitor(null,' ',titulo,null,null));
        }

        public ListaEleitores EleitoresSecao(string zona, string secao)
        {
            ListaEleitores list = new ListaEleitores();
            Eleitor aux;           
            aux = (Eleitor)base.Remove(new Eleitor(null, ' ', null,zona, secao));
            if (aux!=null)
            {
               list.AddEnd(aux);
            }
            

            return list;
        }

        public ListaEleitores ListaPorSexo(char sexo)
        {
            int qtd = this.Count;
            ListaEleitores list = new ListaEleitores();
            Eleitor aux;
            for (int i = 0; i < qtd; i++)
            {
                aux = (Eleitor)base.Remove(new Eleitor(null,sexo, null, null, null));
                if (aux != null)
                {
                    list.AddEnd(aux);
                }
            }

            return list;
        }

        public void AdicionarEmOrdem(Eleitor eleitor)
        {            
            this.AddEnd(eleitor);
            this.Sort();
            
        }

        public void EliminarElementosPosicoesPares()
        {
            Element aux = this.First.Next; //auxiliar para percorrer a lista
            int pos=1;
            while (aux != null) //enquanto o aux não é o último da lista, percorre a lista.
            {
                if (pos % 2 == 0)
                {

                    aux.Previous.Next = aux.Next;
                    if (aux != this.Last)
                    {
                        aux.Next.Previous = aux.Previous;
                    }
                    else
                    {
                        this.Last = aux.Previous;
                    }
                    this.Count--; // atualiza a quantidade de elementos da lista
                    aux = aux.Next;
                    pos++;
                }
                else
                {
                    aux = aux.Next;
                    pos++;
                }
            }
                
            
        }

        public void CarregarDados(string caminhoArquivo) //@"../../Dados.csv"
        {
            using (StreamReader arq = new StreamReader(caminhoArquivo))
            {

                string[] aux;
                arq.ReadLine(); //ler o título das colunas
                while (!arq.EndOfStream)
                {
                    aux = arq.ReadLine().Split('-');
                    this.AddEnd(new Eleitor(aux[0], char.Parse(aux[1]), aux[2], aux[3], aux[4]));

                }
                arq.Close();
            }
           
        }

        public void CarregarEmOrdem(string caminhoArquivo) //@"../../Dados.csv"
        {
            using (StreamReader arq = new StreamReader(caminhoArquivo))
            {

                string[] aux;
                arq.ReadLine(); //ler o título das colunas
                while (!arq.EndOfStream)
                {
                    aux = arq.ReadLine().Split('-');
                    this.AdicionarEmOrdem(new Eleitor(aux[0], char.Parse(aux[1]), aux[2], aux[3], aux[4]));

                }
                arq.Close();
            }
        }
    }
}
