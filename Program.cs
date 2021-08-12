using System;
using System.Collections.Generic;
using ExercicioConjuntos.Entitites;

namespace ExercicioConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso A = new Curso();
            Curso B = new Curso();
            Curso C = new Curso();
            HashSet<Aluno> alunos = new HashSet<Aluno>();
            int quant;

            try
            {

                Console.Write("How many students for course A? ");
                quant = int.Parse(Console.ReadLine());
                A.CadAlunos(quant);
                alunos.UnionWith(A.GetAlunos());

                Console.Write("How many students for course B? ");
                quant = int.Parse(Console.ReadLine());
                B.CadAlunos(quant);
                alunos.UnionWith(B.GetAlunos());

                Console.Write("How many students for course C? ");
                quant = int.Parse(Console.ReadLine());
                C.CadAlunos(quant);
                alunos.UnionWith(C.GetAlunos());

                Console.WriteLine("\nTotal students: " + alunos.Count);

            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
