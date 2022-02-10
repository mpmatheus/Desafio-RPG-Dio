namespace projeto_RPG_DIO.src.Entities
{
    public class Sorcerer : Hero
    {
        public Sorcerer (string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public override string Attack()
        {
            return this.name + " lançou magia";
        }
        public String Attack(int Bonus)
        {
            if (Bonus > 10)
            {
                return this.name + " Soltou uma magia bola de fogo com bonus de: " + Bonus;
            }

            else
                return this.name + " Soltou uma bola de fogo fraca com bonus de: " + Bonus;

        }
        
    }
}