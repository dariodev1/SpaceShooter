using Raylib_cs;
using SpaceShooter.Enums;

namespace SpaceShooter.Model.Abstract
{
    public interface IEnemy
    {
        Dictionary<EnemyLevel,Rectangle> EnemyTextures { get; set; }
    }
}
