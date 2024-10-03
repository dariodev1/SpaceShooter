using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Enemy3 : GameObject
    {
        public override Vector2 Position { get; set; } = new Vector2(700, 700);

        public override GameObjectType ObjectType => GameObjectType.Enemy3;
    }
}
