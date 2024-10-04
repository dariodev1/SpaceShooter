using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Player : GameObject
    {
        public override GameObjectType ObjectType => GameObjectType.Player;
        public Missile? Missile { get; set; } = null;
        public Player(Vector2 position) : base(position)
        {
            Missile = new Missile(Position);
        }

        public void LaunchMissile()
        {
            Missile.Move(Direction.Up);
        }
    }
}
