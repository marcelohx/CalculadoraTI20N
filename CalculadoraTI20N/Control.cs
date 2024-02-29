using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    class Control
    {
        //criei uma conexao com a classe model
        Model mod;

        public Control()
        {
            mod = new Model();//chamando o construtor da classe model //conectando as duas classes
        }//fim do construtor

        public string Menu()
        {
            String msg = "#### Menu ####\n\n" + //criando uma variavel local(so o metodo menu utiliza)
                         "0.Sair\n"           +
                         "1.Somar\n"          +
                         "2.Subtrair\n"       +
                         "3.Multiplicar\n"    +
                         "4.Dividir\n"        +
                         "5.Tabuada\n"        +
                         "6.Raiz\n"           +
                         "7.Potência\n"       +
                         "Escolha uma das opções acima:";
            return msg;
        }//fim do Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                Console.WriteLine(Menu());//Mostrar as opções na tela
                opcao = Convert.ToInt32(Console.ReadLine()); //convertendo o leia(Console.ReadLine()) em int pois ela esta guardando um numero

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar(); //chamando o metodo para coleta
                        Console.WriteLine("A soma dos valores digitados é: " + mod.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("A subtração dos valores digitados é: " + mod.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        Console.WriteLine("A multiplicação dos valores digitados é: " + mod.Multiplicar());
                        break;
                    case 4:
                        Coletar();
                        if (mod.Dividir() == -1)
                        {
                            Console.WriteLine("Impossivel dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão dos valores digitados é: " + mod.Dividir());
                        }
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Tabuada:" + mod.Tabuada());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz:" + mod.Raiz());
                        break;
                    case 7:
                        Coletar();
                        Console.WriteLine("A Potência é: " + mod.Potencia());
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção valida!");
                        break;
                }//fim do switch
            } while(opcao != 0);
        }//fim do Operacao

        public void Coletar()
        {
            //coletando o primeiro numero
            Console.WriteLine("Informe o primeiro número");
            mod.ConsultarNum1 = Convert.ToDouble(Console.ReadLine());
            //consultando o segundo numero
            Console.WriteLine("Informe o segundo número");
            mod.consultarNum2= Convert.ToDouble(Console.ReadLine());
        }// fim do metodo coletar
    }//fim da classe
}//fim do projeto
