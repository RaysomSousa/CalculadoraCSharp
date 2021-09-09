using System;

namespace CalculadoraCSharp
{
    class Program
    {
        enum Menu{ Soma =1, Subtracao,Divisao, Multiplicacao,Potencia,Raiz ,Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo ao Calc, selecione uma das opções: ");
                Console.WriteLine("1.Soma\n2.Subtracao\n3.Divisao\n4.Multiplicação\n5.Potência\n6.Raiz\n7.Sair");

                // Menu opcao = new  (Menu) int.Parse(Console.ReadLine());
                String opcaoTxt = Console.ReadLine();
                int opcaoInt = int.Parse(opcaoTxt);
                Menu opcao = (Menu)opcaoInt;

                Console.WriteLine(opcao);

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.Clear();
            }
        }


         static void Soma()
        {
            Console.WriteLine("Soma de dois numeros");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"A some é: { resultado }");
            Console.WriteLine("Aperte ENTER para voltar para o menu ");
            Console.ReadLine();
        }
         static void Sub()
        {
            Console.WriteLine("Subtração de dois numeros");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"A some é: { resultado }");
            Console.WriteLine("Aperte ENTER para voltar para o menu ");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.WriteLine("Divisão de dois numeros");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = (int)((float)a / (float)b);
            Console.WriteLine($"A some é: { resultado }");
            Console.WriteLine("Aperte ENTER para voltar para o menu ");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois numeros");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"A some é: { resultado }");
            Console.WriteLine("Aperte ENTER para voltar para o menu ");
            Console.ReadLine();
        }
        static void Potencia()
        {
            Console.WriteLine("Potência de um numero");
            Console.WriteLine("Digite a base: ");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado =(int) Math.Pow(basenum,expo);


            Console.WriteLine($"A some é: { resultado }");
            Console.WriteLine("Aperte ENTER para voltar para o menu ");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero");
            Console.WriteLine("Digite numero: ");
            int a = int.Parse(Console.ReadLine());
            
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"A some é: { resultado }");
            Console.WriteLine("Aperte ENTER para voltar para o menu ");
            Console.ReadLine();
        }
    }
}
