namespace projeto_RPG_DIO.src.Entities
{
    public class Thief : Hero
    {
        public Thief (string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public override string Attack()
        {
            return this.name + " Atacou com sua adaga";
        }
    }
}