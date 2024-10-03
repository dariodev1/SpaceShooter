using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Enemy : GameObject
    {
        public override string TexturePath { get => Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName) + @"\Assets\green.png"; }

        public override Vector2 Position { get; set; } = new Vector2(500, 500);


        public Enemy() : base()
        {

        }
    }
}
