using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Enemy2 : GameObject
    {
        public override Vector2 Position { get; set; } = new Vector2(600, 600);

        public override GameObjectType ObjectType => GameObjectType.Enemy2;
    }
}
