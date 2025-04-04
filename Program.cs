namespace Constructors_shpardson_bruce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("CS:GO", "FPS");

            Console.WriteLine($"MY favorite game is {myGame.title} and it is a {myGame.genre} game!");
            
            Game myOtherGame = new Game();
            
            Console.WriteLine($"My favorite game is {myOtherGame.title} and its is rated {myOtherGame.genre} game!");



        }
    }
}