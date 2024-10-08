using Raylib_cs;
using SpaceShooter.Enums;
using SpaceShooter.Model.Abstract;
using System.Numerics;

namespace SpaceShooter.Model
{
    internal class Enemy : GameObject, IEnemy
    {
        public override Rectangle Source => new Rectangle(100, 500, 60, 60);

        public Dictionary<EnemyType, Rectangle> EnemyTextures { get ; set ; }

        public Enemy(Vector2 position) : base(position)
        {
            EnemyTextures = new Dictionary<EnemyType, Rectangle>() { };
            
        }
    }
}
