using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace darabank.banco.testes
{
    class TesteClasseConta
    {
        static void Main(string[] args)
        {
            Type contaDoPaulo = typeof(Conta);
            ConstructorInfo ctor = contaDoPaulo.GetConstructor(System.Type.EmptyTypes);

        }
    }
}
