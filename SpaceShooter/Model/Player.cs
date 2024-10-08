using Raylib_cs;
using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Player : GameObject
    {
        public override GameObjectType ObjectType => GameObjectType.Player;

        public override Rectangle Source => new Rectangle(40,530,115,120);

        public Player(Vector2 position) : base(position)
        {
            
            
        }

        
    }
}
