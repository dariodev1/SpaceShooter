using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Player : GameObject
    {
        public override GameObjectType ObjectType => GameObjectType.Player;

        public Player(Vector2 position): base(position)
        {
            
        }

        public void LaunchMissile()
        {

        }
    }
}
