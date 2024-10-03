using Raylib_cs;
using System.Numerics;

namespace SpaceShooter.Model.Abstract
{
    internal abstract class GameObject
    {

        public  Vector2 Position { get; set; }
        internal Texture2D Texture2D { get; set; }
        public abstract GameObjectType ObjectType { get; }
        protected GameObject(Vector2 position)
        {
            Position = position;
            LoadTexture();
        }

        private void LoadTexture()
        {
            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);
            switch (ObjectType)
            {
                case GameObjectType.Enemy1:
                    path += @"\Assets\enemy1.png";
                    break;
                case GameObjectType.Enemy2:
                    path += @"\Assets\enemy2.png";
                    break;
                case GameObjectType.Enemy3:
                    path += @"\Assets\enemy3.png";
                    break;
                case GameObjectType.Player:
                    path += @"\Assets\player.png";
                    break;
                case GameObjectType.Missile:
                    path += @"\Assets\missile.png";
                    break;
                default:
                    break;
            }
            if (File.Exists(path))
            {
                Texture2D = Raylib.LoadTexture(path);
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
