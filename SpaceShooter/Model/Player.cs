using Raylib_cs;
using System.Reflection;

namespace SpaceShooter.Model
{
    internal class Player
    {
        public Texture2D Texture2D { get; }

        public Player()
        {
            string startupPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName)+ @"\Assets\player.png";
            if (File.Exists(startupPath))
            {
                Texture2D = Raylib.LoadTexture(startupPath);
            }
            else 
            {
                Console.WriteLine("Not Exist");
            }
            
        }
    }
}
