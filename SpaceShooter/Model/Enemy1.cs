using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Enemy1 : GameObject
    {

        public override Vector2 Position { get; set; } = new Vector2(500, 500);

        public override GameObjectType ObjectType => GameObjectType.Enemy1;

        
    }
}
