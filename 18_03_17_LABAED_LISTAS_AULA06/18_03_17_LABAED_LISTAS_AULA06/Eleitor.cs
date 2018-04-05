using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLibrary;

namespace _18_03_17_LABAED_LISTAS_AULA06
{
    class Eleitor : Data
    {
        string nome;
        char sexo;
        string titulo,zona,secao;
        
        public Eleitor(string nome, char sexo, string titulo, string zona, string secao)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.titulo = titulo;
            this.zona = zona;
            this.secao = secao;
        }

        public string Nome { get => nome; set => nome = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Zona { get => zona; set => zona = value; }
        public string Secao { get => secao; set => secao = value; }

        /// <summary>
        /// Compara esta instância com um Eleitor especificado e indica se essa instância precede, segue ou aparece na mesma posição na ordem de classificação como o Eleitor especificado.
        /// </summary>
        /// <param name="obj">O Eleitor a ser comparado com o a atual instância</param>
        /// <returns>Menor que zero, esta instância precede 'obj'; zero, esta instância ocorre na mesma posição que 'obj'; maior que zero, esta instância segue 'obj' na ordem de classificão.</returns>
        public override int CompareTo(Data obj) //Compara o Nome do eleitor
        {
            Eleitor aux = (Eleitor)obj;
            if (this.nome.CompareTo(aux.nome) < 0)
            {
                return -1;
            }
            else if (this.nome.CompareTo(aux.nome) > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Determina se o Eleitor epecificado é igual ao Eleitor da atual instância
        /// </summary>
        /// <param name="other">O Eleitor a ser comparado com o a atual instância</param>
        /// <returns>True se o Eleitor especificado for igual ao Eleitor atual; caso contrário, False</returns>
        public override bool Equals(Data other) // compara po titulo, zona e seção, ou por sexo;
        {
            Eleitor aux = (Eleitor)other;
            if (aux.titulo == null)
            {
                if (aux.zona == null || aux.secao == null)
                {
                    return (this.sexo == aux.sexo);
                }
                else return (this.zona == aux.zona && this.secao == aux.secao);
            }
            else return (this.titulo == aux.titulo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retorna uma cadeia de caracteres que representa o Eleitor atual.</returns>
        public override string ToString()
        {
            return string.Format("{0,-25}{1,-5}{2,-15}{3,-5}{4,-5}\n",this.nome,this.sexo.ToString(),this.titulo,this.zona,this.secao);
        }
    }
}
