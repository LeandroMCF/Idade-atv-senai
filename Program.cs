using System;

namespace Idade_atv_senai
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int mes;
            int dia;
            int horas;
            int min;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            mes = idade * 12;
            dia = 365 * idade;
            horas = 8760 * idade;
            min = 525600 * idade;
            Console.WriteLine("Você tem "+mes+" meses");
            Console.WriteLine("Você tem "+dia+" dias");
            Console.WriteLine("Você tem "+horas+" horas");
            Console.WriteLine("Você tem "+min+" minutos");
        }
    }
}
