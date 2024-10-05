using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Enemy2 : GameObject
    {
        public override GameObjectType ObjectType => GameObjectType.Enemy2;


        public Enemy2(Vector2 position) : base(position)
        {
            base.LoadTexture(@"\Assets\enemy2.png");
        }

    }
}
