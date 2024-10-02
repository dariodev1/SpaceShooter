using Raylib_cs;
using SpaceShooter.Model.Abstract;

namespace SpaceShooter.Model
{
    internal class Player : GameObject
    {
        public override string TexturePath { get => Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName) + @"\Assets\player.png"; }

        public Player(): base()
        {
            
            
        }


    }
}
