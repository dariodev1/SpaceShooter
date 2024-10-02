using Raylib_cs;
using System.Numerics;

namespace SpaceShooter.Model.Abstract
{
    internal abstract class GameObject
    {
        public abstract string TexturePath { get; }
        public abstract Vector2 Position { get; set; }
        internal Texture2D Texture2D { get; set; }

        protected GameObject()
        {
            LoadTexture();
        }

        private void LoadTexture()
        {
            if (TexturePath is not null && File.Exists(TexturePath))
            {
                Texture2D = Raylib.LoadTexture(TexturePath);
            }
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
