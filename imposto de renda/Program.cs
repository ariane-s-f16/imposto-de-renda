using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prsojeto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual é o salario bruto?");
            double sal_bru = double.Parse(Console.ReadLine());

            Console.WriteLine("qual é a quantidade de filhos do usuario?");
            int filhos = int.Parse(Console.ReadLine());

            Console.WriteLine("qual é o valor do vale alimentação?");
            double vali = double.Parse(Console.ReadLine());

            Console.WriteLine("qual é o valor por filhos?");
            double v_f = double.Parse(Console.ReadLine());

            double s_total = sal_bru + vali + (v_f * filhos);
            double desconto = 0;
            double des2 = 0;
            double des = 0;
            // inss//

            if (sal_bru <= 1412)
            {
                des = (sal_bru * 0.075);
                desconto = s_total - des;
            }
            else if (sal_bru >= 1412 && sal_bru <= 2666.68)
            {
                des = (sal_bru * 0.09) - 21.18;
                desconto = s_total - des;
            }
            else if (sal_bru >= 2666.68 && sal_bru <= 4000.03)
            {
                des = (sal_bru * 0.12) - 101.18;
                desconto = s_total - des;
            }
            else if (sal_bru >= 4000.03 && sal_bru <= 7786.02)
            {
                des = (sal_bru * 0.14) - 181.18;
                desconto = s_total - des;
            }
            else if (sal_bru >= 7786.02)
            {
                des = (908.85);
                desconto = s_total - des;

            }
            else
            {
                Console.WriteLine("esse valor esta incorreto");
            }

            //irrf

            if (sal_bru <= 2259.20)
            {
                des2 = sal_bru - 0;

            }
            else if (sal_bru >= 2259.20 && sal_bru <= 2826.65)
            {
                des2 = (sal_bru * 0.075) - 169.44;

            }
            else if (sal_bru >= 2826.65 && sal_bru <= 3751.05)
            {
                des2 = (sal_bru * 0.15) - 381.44;

            }
            else if (sal_bru >= 3751.05 && sal_bru <= 4664.68)
            {

                des2 = (sal_bru * 0.225) - 662.77;

            }
            else if (sal_bru >= 4664.68)
            {
                des2 = (sal_bru * 0.275) - 896.6;


            }
            else
            {
                Console.WriteLine("esse valor esta incorreto");
            }
            double salariol = desconto - des2;

            Console.WriteLine("o salário bruto é:" + sal_bru);
            Console.WriteLine("o salario líquido é: " + salariol);
            Console.WriteLine("a quantidade de filhos é: " + filhos);
            Console.WriteLine("o valor do imposto de renda é:" + des2);
            Console.WriteLine("o valor do inss é:" + des);
            Console.WriteLine("o valor por filho é:" + v_f);
            Console.WriteLine("a quantidade de filhos é:" + filhos);
            Console.WriteLine("a quantidade de filhos é:" + vali);

            Console.ReadKey();

        }


    }
}

