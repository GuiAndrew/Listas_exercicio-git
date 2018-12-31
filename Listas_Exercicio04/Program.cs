using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Git Hub:
            Console.WriteLine("Este programa foi adicionado ao Git!!");
            Console.WriteLine("Este programa foi adicionado ao GitHub!!");

            Console.WriteLine();

            // Fazer o enconding:
            Console.OutputEncoding = Encoding.UTF8;

            // Atributos:
            int n;
            List<Funcionario> funcionarios;
            int nifComparar;
            int posicaoNifLista;
            double aumento;

            // Interação com o user:
            Console.Write("Quantos funcionários serão cadastrados: ");
            n = int.Parse(Console.ReadLine());

            //// Logica e mostrar resultado:
            // funcionarios = new List<Funcionario>();
            // for (int i = 0; i < n; i++)
            // ou:
            funcionarios = new List<Funcionario>(n);
            for (int i = 0; i < funcionarios.Capacity; i++)
            {
                Console.WriteLine("Dados do " + (i + 1) + "º funcionário:");
                Console.Write("NIF: ");
                int nif = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(nif, nome, salario));

                Console.WriteLine();
            }

            Console.Write("Digite o NIF do funcionário que terá aumento: ");
            nifComparar = int.Parse(Console.ReadLine());

            posicaoNifLista = funcionarios.FindIndex(f => f.Nif == nifComparar);

            if (posicaoNifLista != -1)
            {
                Console.Write("Digite a porcentagem de aumento: ");
                aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios[posicaoNifLista].AumentoSalario(aumento);
            }
            else
            {
                Console.Write("NIF INEXISTENTE!");
            }

            Console.WriteLine();

            Console.WriteLine("Listagem actualizada dos funcionários:");
            foreach (Funcionario item in funcionarios)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
