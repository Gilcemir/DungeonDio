namespace DungeonDio
{
    public class Bard : Hero
    {
        public Bard(string Name, int Level)
        {          
            this.Name = Name;
            this.Level = Level;
            this.Type = "bard";  
        }
        public string PlaySong(string typeSong = null){
            string song = this.Name;
            switch (typeSong){
                case "drums":
                song+=" played the Drums of War! Now all of his allies feels ready to battle!";
                break;
                case "flut":
                song+=" played his flut! Everyone's feeling better.";
                break;
                case "harp":
                song+=" played his Harp! Are you in Love?";
                break;
                default:
                song+=" is singing a Song!";
                break;
            }
            return song;
        }
    }
}