using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Missile : GameObject
    {
        public Missile(Vector2 position) : base(position)
        {

        }

        public override string TexturePath => @"\Assets\missile.png";
        public override GameObjectType ObjectType => GameObjectType.Missile;

        public override void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Position = new Vector2(Position.X, Position.Y - 10);
                    break;
                case Direction.Down:
                    Position = new Vector2(Position.X, Position.Y + 10);
                    break;
                case Direction.Left:
                    Position = new Vector2(Position.X - 10, Position.Y);
                    break;
                case Direction.Right:
                    Position = new Vector2(Position.X + 10, Position.Y);
                    break;
                default:
                    break;
            }
        }
    }
}
