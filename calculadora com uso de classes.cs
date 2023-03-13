using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            Mate Calculo =new Mate();
            void interfa()
            {
                Console.WriteLine("[1]soma\n" +
             "[2]subtração\n" +
             "[3]mutiplicação\n" +
             "[4]divisão\n" +
             "[0]sair\n");
                Console.Clear();
            }
             void Coleta()
            {
                
                Console.Clear();
                Console.WriteLine("1° numero");
                Calculo.n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2° numero");
                Calculo.n2 = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            interfa();
            int opc=int.Parse(Console.ReadLine());
            switch (opc){
                case 1:
                    {
                        Coleta();
                        Console.WriteLine($"se somarmos {Calculo.n1} com mais {Calculo.n2} resulta em {Calculo.Soma(Calculo.n1, Calculo.n2)}");
                        Console.WriteLine("aperte qualquer tecla para finalizar o programa.......................................");
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Coleta();
                        Console.WriteLine($"se subtrairmos {Calculo.n1} com menos {Calculo.n2} resulta em {Calculo.Sub(Calculo.n1, Calculo.n2)}");
                        Console.WriteLine("aperte qualquer tecla para finalizar o programa.......................................");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    { 
                    Coleta();
                    Console.WriteLine($"se mutiplicarmos {Calculo.n1} vezes o numero {Calculo.n2} resulta em {Calculo.Mut(Calculo.n1, Calculo.n2)}");
                        Console.WriteLine("aperte qualquer tecla para finalizar o programa.......................................");
                        Console.ReadKey();
                    break;
                    }
                case 4:
                    {
                        Coleta();
                        Console.WriteLine($"se dividirmos {Calculo.n1} por {Calculo.n2} resulta em {Calculo.Div(Calculo.n1, Calculo.n2)}");
                        Console.WriteLine("aperte qualquer tecla para finalizar o programa.......................................");
                        Console.ReadKey();
                        break;
                    }
                case 0:
                    {
                        Console.WriteLine("até mais tchau");
                        Console.WriteLine("aperte qualquer tecla para finalizar o programa.......................................");
                        Console.ReadKey();
                        break;
                    }
                default:
                    {


                        break;
                    }
            }
            
            
        }
    }
    class Mate
    {
        public int n1;
        public int n2;
        
        public int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
        public int Mut(int n1, int n2)
        {
            return n1 * n2;
        }
        public int Div(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
