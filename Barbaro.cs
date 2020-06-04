namespace Aula10Polimorfismo
{
    public class Barbaro : Player
    {
        public override void Atacar(){
        System.Console.WriteLine("Ataque com a clava: IRA DOS TITÃS ");
        System.Console.WriteLine("Aumento da IRA");    
        }

        public override void Defender(){
        base.Defender();
        System.Console.WriteLine("Com o aumento da IRA o dano do inimigo e reduzido 30%!!");
        }
    }
}