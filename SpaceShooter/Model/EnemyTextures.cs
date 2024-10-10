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
                case EnemyLevel.One:
                    return new Rectangle(360, 320, 110, 140);
                case EnemyLevel.Two:
                    return new Rectangle(500, 325, 105, 130);
                case EnemyLevel.Three:
                    return new Rectangle(615, 315, 150, 145);
                case EnemyLevel.Four:
                    return new Rectangle(785, 315, 135, 145);
                case EnemyLevel.Five:
                    return new Rectangle(805, 160, 115, 125);
                case EnemyLevel.Six:
                    return new Rectangle(665, 160, 115, 125);
                case EnemyLevel.Seven:
                    return new Rectangle(495, 190, 155, 95);
                case EnemyLevel.Eight:
                    return new Rectangle(330, 170, 145, 105);

                default:
                    return new Rectangle(0, 0, 0, 0);
            }
        }
    }
}
