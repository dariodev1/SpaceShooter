using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Player : GameObject
    {
        public override Vector2 Position { get; set; } = new Vector2(300, 300);

        public override GameObjectType ObjectType => GameObjectType.Player;

        public Player(): base()
        {
            
        }


    }
}
