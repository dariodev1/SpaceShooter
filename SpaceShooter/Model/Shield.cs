using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Shield : GameObject
    {
        public override string TexturePath { get => Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName) + @"\Assets\player.png"; }

        public override Vector2 Position { get; set; } = new Vector2(300, 300);
    }
}
