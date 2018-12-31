using System;

namespace Listas_Exercicio04
{
    public class Funcionario
    {
        // Propriedades:
        public int Nif { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        // Construtores:
        public Funcionario(int nif, string nome, double salario)
        {
            Nif = nif;
            Nome = nome;
            Salario = salario;
        }

        // Metodos:
        public void AumentoSalario(double porcento)
        {
            double aux = ((porcento / 100) * Salario);
            Salario += aux;
        }

        public override string ToString()
        {
            return 
                "NIF: " + 
                Nif +
                ", " +
                "Nome: " + 
                Nome +
                ", " +
                "Salario: " + 
                Salario.ToString("F2") + 
                "€";
        }
    }
}
