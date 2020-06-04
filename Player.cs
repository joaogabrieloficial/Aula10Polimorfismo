namespace Aula10Polimorfismo
{
    public class Player
    {
        public virtual void Atacar(){
            System.Console.WriteLine("Atacando normalmente");

        }

        public virtual void Defender(){
            System.Console.WriteLine("Defendendo normalmente");
        }

    }
}