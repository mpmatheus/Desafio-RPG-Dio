namespace projeto_RPG_DIO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard (string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public override string Attack()
        {
            return this.name + " lançou cura";
        }
      
        public string Attack(int Bonus)
        {
            if (Bonus > 10){
                return this.name + " Lançou uma cura super efetiva com bonus de: " + Bonus;
            }
            else
            return this.name + " Lançou uma cura com força fraca com bonus de: " + Bonus;
        }
    }
}