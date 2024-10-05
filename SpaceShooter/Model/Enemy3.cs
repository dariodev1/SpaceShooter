using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Enemy3 : GameObject
    {
        public override GameObjectType ObjectType => GameObjectType.Enemy3;
        public override string TexturePath => @"\Assets\enemy3.png";
        public Enemy3(Vector2 position) : base(position)
        {
            
        }
    }
}
