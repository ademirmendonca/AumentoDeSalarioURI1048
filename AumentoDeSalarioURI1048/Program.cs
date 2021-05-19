using System;
using System.Globalization;

namespace AumentoDeSalarioURI1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0.00, total = 0;

            //Faz a leitura do salário com duas casas decimais 
            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            //Efetura o cálculo conforme o salario
            
            if (salario <= 400.00)
            {
                total = salario * 15 / 100;
                Console.WriteLine("Novo salario: " + ((total + salario).ToString("F2", CultureInfo.InvariantCulture)));
                Console.WriteLine("Reajuste ganho: " + total.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }

            if (salario >= 400.01 && salario <= 800.00)
            {
                total = salario * 12 / 100;
                Console.WriteLine("Novo salario: " + ((total + salario).ToString("F2", CultureInfo.InvariantCulture)));
                Console.WriteLine("Reajuste ganho: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }

            if (salario >= 800.01 && salario <= 1200.00)
            {
                total = salario * 10 / 100;
                Console.WriteLine("Novo salario: " + ((total + salario).ToString("F2", CultureInfo.InvariantCulture)));
                Console.WriteLine("Reajuste ganho: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            if (salario >= 1200.01 && salario <= 2000.00)
            {
                total = salario * 7 / 100;
                Console.WriteLine("Novo salario: " + ((total + salario).ToString("F2", CultureInfo.InvariantCulture)));
                Console.WriteLine("Reajuste ganho: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            if (salario >= 2000.01)
            {
                total = salario * 4 / 100;
                Console.WriteLine("Novo salario: " + ((total + salario).ToString("F2", CultureInfo.InvariantCulture)));
                Console.WriteLine("Reajuste ganho: " + total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
    
    
    
}
