namespace DungeonDio
{
    public abstract class Hero
    {
        
        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }
        

        public override string ToString(){
            return this.Name + " " + this.Level + " " +this.Type;
        }
    }
}