using Raylib_cs;
using SpaceShooter.Model;
using SpaceShooter.Model.Abstract;

namespace SpaceShooter
{
    internal class Game
    {
        List<GameObject> Enemies = new List<GameObject>();
        Player? player = null;
        int screenWidth = 1200;
        int screenHeight = 800;
        public Game()
        {
            Raylib.InitWindow(screenWidth, screenHeight, "Hello World");
            player = new Player(new System.Numerics.Vector2(400, 400));

            GenerateRowEnemies(8, GameObjectType.Enemy1);
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                
                Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Yellow);
                Raylib.DrawTexture(player.Texture2D, (int)player.Position.X, (int)player.Position.Y, Color.Brown);
                Raylib.DrawTextureEx(player.Missile.Texture2D, new System.Numerics.Vector2(player.Missile.Position.X, player.Missile.Position.Y), 1, 0.25F, Color.Blue);

                foreach (GameObject enemy in Enemies)
                {
                    Raylib.DrawTexture(enemy.Texture2D, (int)enemy.Position.X, (int)enemy.Position.Y, Color.Brown);
                }
                if (Raylib.IsKeyPressed(KeyboardKey.Right) || Raylib.IsKeyPressedRepeat(KeyboardKey.Right))
                {
                    if (player.Position.X + player.Texture2D.Width < screenWidth)
                    {
                        player.Move(Direction.Right);
                        player.Missile.Move(Direction.Right);
                    }

                }
                else if (Raylib.IsKeyPressed(KeyboardKey.Left) || Raylib.IsKeyPressedRepeat(KeyboardKey.Left))
                {
                    if (player.Position.X >= 10)
                    {
                        player.Move(Direction.Left);
                        player.Missile.Move(Direction.Left);
                    }
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.Space) || Raylib.IsKeyPressedRepeat(KeyboardKey.Space))
                {
                    while (IsMissileOutsideOfBoard())
                    {
                        player.LaunchMissile();
                    }
                }
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
            Console.WriteLine("Hello, World!");
        }

        private void GenerateRowEnemies(int numberOfEnemiesInRow, GameObjectType type)
        {
            int posX = 100;
            int posY = 100;

            for (int j = 0; j < numberOfEnemiesInRow; j++)
            {
                switch (type)
                {
                    case GameObjectType.Enemy1:
                        Enemies.Add(new Enemy1(new System.Numerics.Vector2(posX, posY)));
                        break;
                    case GameObjectType.Enemy2:
                        Enemies.Add(new Enemy2(new System.Numerics.Vector2(posX, posY)));
                        break;
                    case GameObjectType.Enemy3:
                        Enemies.Add(new Enemy3(new System.Numerics.Vector2(posX, posY)));
                        break;
                    default:
                        break;
                }

                posX += 50;
            }


        }

        private bool IsMissileOutsideOfBoard()
        {
            if (player.Missile.Position.Y <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
