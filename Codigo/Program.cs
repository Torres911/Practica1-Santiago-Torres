using System;
using Codigo.Fachada;

namespace Codigo
{
    class Program
    {
        static void Main(string[] args){
            Fachada.Fachada fachadaGranja = new Fachada.Fachada();
            fachadaGranja.Menu();
        }
    }
}
