using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("Elfos");
            Elfos elfo =new Elfos();
            elfo.Atacar();
            elfo.Defender();


            System.Console.WriteLine("Barbáro");
            Barbaro barbaro =new Barbaro();
            barbaro.Atacar();
            barbaro.Defender();
        }

    }
}
