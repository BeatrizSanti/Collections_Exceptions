using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeitoEmSala_Aula6_Collections_Exceptions
{
    public class Revisao
    {
        private string Nome { get; set; }

        public Revisao()
        {
            Nome = "Valor Padrão";
        }

        public Revisao(string nome)
        {
            Nome = nome;
        }
    }

    public class Carro : Revisao
    {
        private string cor; //Esse atributo está encapsulado

        public Carro()
        {
            
        }

        public Carro(string nome) : base(nome)
        {

        }

        public void DefinirCorCarro(string novaCor)
        { 
            cor = novaCor;
        }

        public string RetornarCorCarro() 
        {
            return this.cor;
        }
    }

    public class Animal
    { 
        protected bool TemPelo { get; set; }
    }

    public class Gato : Animal
    { 
        public void DefinirTemPelo()
        { 
            TemPelo = true;
        }
    }
}
