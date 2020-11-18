﻿namespace Darabank.Modelos.Funcionarios
{
    class Auxiliar : Funcionario
    {

        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}

