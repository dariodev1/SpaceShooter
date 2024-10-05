using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Enemy1 : GameObject
    {
        public override GameObjectType ObjectType => GameObjectType.Enemy1;

        public override string TexturePath => @"\Assets\enemy1.png";

        public Enemy1(Vector2 position) : base(position)
        {

        }
    }
}
