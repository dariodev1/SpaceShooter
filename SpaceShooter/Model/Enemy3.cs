using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Enemy3 : GameObject
    {
        public override GameObjectType ObjectType => GameObjectType.Enemy3;

        public Enemy3(Vector2 position) : base(position)
        {
            base.LoadTexture(@"\Assets\enemy3.png");
        }
    }
}
