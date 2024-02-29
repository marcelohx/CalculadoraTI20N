using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    class Model
    {
        //Área de variaveis
        private double num1;
        private double num2;

        //Metodo Construtor = Instancia as variáveis
        public Model()
        {
            ConsultarNum1 = 0;
            num2 = 0;
        }//fim do Construtor


        //Metodo GET e SET
        public double ConsultarNum1
        {
            get { return num1; }
            set { num1 = value; }
        }//Fim do GET e SET

        public double consultarNum2
        {
            get { return num2; }
            set { num2 = value; }
        }//Fim do GET e SET

        public double Somar()
        {
            return ConsultarNum1 + consultarNum2;
        }//Fim do somar

        public double Subtrair()
        {
            return ConsultarNum1 - consultarNum2;
        }//Fim do metodo subtrair

        public double Multiplicar()
        {
            return ConsultarNum1 * consultarNum2;
        }//Fim do Multiplicar

        public double Dividir()
        {
            if (consultarNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return ConsultarNum1 / consultarNum2;
            }
        }//Fim do dividir

        public string Tabuada()
        {
            string resultado = "";
            resultado += "Tabuada do " + ConsultarNum1;
            for (int i=0; i <= 10; i++)
            {
                resultado += "\n" + ConsultarNum1 +  "*" + i + "=" + (ConsultarNum1 * i); // "+=" diz que a variavel resultado recebe ela mesma + o que esta na frente
            }//Fim do for

            resultado += "\n\nTabuada do " + consultarNum2;
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + consultarNum2 + "*" + i + "=" + (consultarNum2 * i); // "+=" diz que a variavel resultado recebe ela mesma + o que esta na frente
            }//Fim do for

            return resultado;
        }//fim do metodo tabuada

        public string Raiz()
        {
            string resultado = "";

            resultado = "A raiz de " + ConsultarNum1 + " é: " + Math.Sqrt(ConsultarNum1) +
                        "\nA raiz de " + consultarNum2 + " é: " + Math.Sqrt(consultarNum2);

            return resultado;
        }//Fim da Raiz

        public double Potencia()
        {
            return Math.Pow(ConsultarNum1, consultarNum2);
        }//Fim do potencia


    }//Fim da classe
}//Fim do projeto
