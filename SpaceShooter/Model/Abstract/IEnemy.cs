using Raylib_cs;
using SpaceShooter.Enums;

namespace SpaceShooter.Model.Abstract
{
    public interface IEnemy
    {
        Dictionary<EnemyType,Rectangle> EnemyTextures { get; set; }
    }
}
