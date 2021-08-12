using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioConjuntos.Entitites
{
    class Curso
    {
        HashSet<Aluno> alunos = new HashSet<Aluno>();

        public void CadAlunos(int quant)
        {
            for (int i = 0; i < quant; i++)
            {
                alunos.Add(new Aluno(int.Parse(Console.ReadLine())));
            }
        }

        public HashSet<Aluno> GetAlunos()
        {
            return alunos;
        }
    }
}
