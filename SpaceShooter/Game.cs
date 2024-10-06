using Raylib_cs;
using SpaceShooter.Model;
using SpaceShooter.Model.Abstract;

namespace SpaceShooter
{
    internal class Game
    {
        List<GameObject> Enemies = new List<GameObject>();
        Missile? playerMissile = null;
        Player? player = null;
        int screenWidth = 1200;
        int screenHeight = 800;
        public Game()
        {
            Raylib.InitWindow(screenWidth, screenHeight, "Hello World");
            player = new Player(new System.Numerics.Vector2(400, 400));
            playerMissile = new Missile(new System.Numerics.Vector2(player.Position.X, player.Position.Y));
            LoadTexture(player);
            GenerateRowEnemies(8, GameObjectType.Enemy1);
            foreach (var enemy in Enemies)
            {
                LoadTexture(enemy);
            }
            LoadTexture(playerMissile);
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Yellow);
                Raylib.DrawTexture(player.Texture2D, (int)player.Position.X, (int)player.Position.Y, Color.Brown);


                foreach (GameObject enemy in Enemies)
                {
                    Raylib.DrawTexture(enemy.Texture2D, (int)enemy.Position.X, (int)enemy.Position.Y, Color.Brown);
                }
                if (Raylib.IsKeyPressed(KeyboardKey.Right) || Raylib.IsKeyPressedRepeat(KeyboardKey.Right))
                {
                    if (player.Position.X + player.Texture2D.Width < screenWidth)
                    {
                        player.Move(Direction.Right);
                        playerMissile.Move(Direction.Right);
                    }

                }
                else if (Raylib.IsKeyPressed(KeyboardKey.Left) || Raylib.IsKeyPressedRepeat(KeyboardKey.Left))
                {
                    if (player.Position.X >= 10)
                    {
                        player.Move(Direction.Left);
                        playerMissile.Move(Direction.Left);
                    }
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.Space) || Raylib.IsKeyPressedRepeat(KeyboardKey.Space))
                {
                    LaunchPlayerMissile();

                }
                if (IsMissileWithinBoard())
                {
                    playerMissile.Move(Direction.Up);
                    Raylib.DrawTextureEx(playerMissile.Texture2D, playerMissile.Position, 1, 0.25F, Color.Blue);
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

        private bool IsMissileWithinBoard()
        {
            if (playerMissile.Position.Y <= 0)
            {
                return false;
            }
            return true;
        }

        private void LoadTexture(GameObject obj)
        {
            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);
            path += obj.TexturePath;

            if (File.Exists(path))
            {
                obj.Texture2D = Raylib.LoadTexture(path);
            }
        }

        private void UnloadTexture(GameObject obj)
        {
            if (obj.CanUnloadTexture)
            {
                Raylib.UnloadTexture(obj.Texture2D);
                obj.CanUnloadTexture = false;
            }

        }

        public void LaunchPlayerMissile()
        {
            playerMissile.Position = player.Position;
        }
    }
}
