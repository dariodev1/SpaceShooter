using Raylib_cs;
using System.Numerics;

namespace SpaceShooter.Model.Abstract
{
    internal abstract class GameObject
    {
        public Vector2 Position { get; set; }
        internal Texture2D Texture2D { get; set; } 
        public abstract GameObjectType ObjectType { get; }
        public string TexturePath { get; } = @"\Assets\resizedGraphics.png";
        public bool CanUnloadTexture { get; set; }
        public bool CanBeDraw { get; set; } = true;
        public abstract Rectangle Source { get; }
        public Color Color { get; set; } = Color.White;

        protected GameObject(Vector2 position)
        {
            Position = position;

        }

        public virtual void Move(Direction direction)
        {
            switch (direction)
            {
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
