namespace Aula10Polimorfismo
{
    public class Elfos : Player
    {
        public override void Atacar(){
            System.Console.WriteLine("Ataque com o arco: A grande ALVORADA ");
        }

        public override void Defender(){
            System.Console.WriteLine("Ativou escudo supremo de luz!!");
        }
    }
}