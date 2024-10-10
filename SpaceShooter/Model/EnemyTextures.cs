using Raylib_cs;
using SpaceShooter.Enums;

namespace SpaceShooter.Model
{
    internal static class EnemyTextures
    {
        public static Rectangle GetTextureForEnemy(EnemyLevel level)
        {
            switch (level)
            {
                case EnemyLevel.Level_One:
                    return new Rectangle(360, 320, 110, 140);
                case EnemyLevel.Level_Two:
                    return new Rectangle(500, 325, 105, 130);
                case EnemyLevel.Level_Three:
                    return new Rectangle(615, 315, 150, 145)
                case EnemyLevel.Level_Four:
                    return new Rectangle(360, 320, 110, 140);

                default:
                    return new Rectangle(0, 0, 0, 0);
            }
        }
    }
}
