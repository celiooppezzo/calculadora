using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class cl_operacoes
    {
        //=========== Atributos privados da classe==============
        private double x =  new double();
        private double y = new double();
        private double resposta = new double();

        public double X
        {
            set {x = value;}
        }
        public double Y
        {
            set {y = value;}
        }

        public double Resposta
        {
            get {return resposta;}
        }

        //============Métodos get e set=========================


        //=====================Operacao de adicao================
        public double somar()
        {
            this.resposta = this.x + this.y;
            return this.resposta;
        }

    }
}
