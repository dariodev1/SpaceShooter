using Raylib_cs;
using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Enemy3 : GameObject
    {
        public override GameObjectType ObjectType => GameObjectType.Enemy3;
        public override Rectangle Source => new Rectangle(100, 500, 60, 60);
        public Enemy3(Vector2 position) : base(position)
        {
            
        }
    }
}
