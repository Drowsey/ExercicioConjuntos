using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioConjuntos.Entitites
{
    class Aluno
    {
        public int Matricula { get; set; }

        public Aluno(int matricula)
        {
            Matricula = matricula;
        }

        public override bool Equals(object obj)
        {
            Aluno aluno = obj as Aluno;
            return Matricula.Equals(aluno.Matricula);
        }
        public override int GetHashCode()
        {
            return Matricula.GetHashCode();
        }
    }
}
