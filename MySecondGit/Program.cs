namespace MySecondGit
{
    internal class Program
    {
        struct Player
        {
            public string name;
            public int level;
        }

        struct Monster
        {
            public string name;
            public int hp;
        }

        static void Main(string[] args)
        {
            Player player = new Player() { name = "용사", level = 1 };

            Monster monster = new Monster() {name = "오크", hp = 15};
        }
    }
}
