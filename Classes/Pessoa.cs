using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Pessoa
    {
        public Pessoa() { }
        public Pessoa(string nome, string profissao)
        {
            Nome = nome;
            Profissao = profissao;
        }
        public Pessoa(string nome, string profissao, Telefone telefone)
        {
            Nome = nome;
            Profissao = profissao;
            Telefone = telefone;
        }
        #region Propriedades
        public string Nome { get; set; }
        public string Profissao { get; set; }
        //public ICollection<Telefone> Telefones { get; set; }
        public Telefone Telefone { get; set; }

        #endregion


        #region Comportamentos

        public string Imprimir()
        {
            Validar();
            //StringBuilder impressao = new StringBuilder();
            //impressao.Append($"Nome : {Nome} - Profissão : {Profissao}");
            //return impressao.ToString();

            return $"Nome : {Nome} - Profissão : {Profissao} - { Telefone.Imprimir() }";
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Profissao) || string.IsNullOrEmpty(Nome))
                throw new Exception("Todos os campos são obrigatórios");

        }

        public void AdicionarTelefone(Telefone telefone)
        {
            Telefone = telefone;
        }

        #endregion


    }
}

