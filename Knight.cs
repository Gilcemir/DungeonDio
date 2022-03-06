namespace DungeonDio
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = "knight";
        }
        public string Attack(int dmg = 0){
            string attack = this.Name + " Sword attack! ";
            switch (dmg){
                case < 0: 
                    attack+=" Had no effect!";
                    break;
                case < 100:
                    attack+=" Great! Bonus damage: "+ dmg;
                    break;
                case >=100: 
                    attack+=" Super effective! Bonus damage: "+dmg;
                    break;
                default:
                break;
            }
            return attack;
        }
    }
}