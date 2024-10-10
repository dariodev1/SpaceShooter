using Raylib_cs;
using SpaceShooter.Model;
using SpaceShooter.Model.Abstract;
using System;

// loading texteures from source:
//Raylib.DrawTextureRec(playerMissile.Texture2D, new Rectangle(50, 45, 75, 65), new System.Numerics.Vector2(0, 0), Color.White); lives texture 
//Raylib.DrawTextureRec(gameTexture, new Rectangle(360,320,110,140), new System.Numerics.Vector2(100,100), player.Color); enemy lvl1
namespace SpaceShooter
{
    internal class Game
    {
        private const string gameTexturePath = @"\Assets\gameGraphic.png";
        private Texture2D gameTexture;
        List<Enemy> Enemies = new List<Enemy>();
        Missile? playerMissile = null;
        Player? player = null;
        int screenWidth = 1800;
        int screenHeight = 900;
        public Game()
        {
            Raylib.InitWindow(screenWidth, screenHeight, "Hello World");
            LoadGameTexture();
            Raylib.SetWindowPosition(100, 200);
            player = new Player(new System.Numerics.Vector2(400, 400));
            playerMissile = new Missile(new System.Numerics.Vector2(player.Position.X, player.Position.Y));
            //GenerateEnemies(8, GameObjectType.Enemy1);
            foreach (var enemy in Enemies)
            {
                
            }
            
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                //Raylib.DrawTextureRec(gameTexture, player.Source, player.Position, player.Color);
                Raylib.DrawTextureRec(gameTexture, new Rectangle(330,170,145,105), new System.Numerics.Vector2(100,100), player.Color);


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
                if (playerMissile.WasFired && IsMissileWithinBoard())
                {
                    playerMissile.Move(Direction.Up);
                    IfMissileHittedEnemy();
                    //Raylib.DrawTextureEx(playerMissile.Texture2D, playerMissile.Position, 1, 0.25F, Color.Blue);
                }
                //Raylib.DrawRectangle((int)Enemies[0].Position.X, (int)Enemies[0].Position.Y, (int)Enemies[0].Texture2D.Width, (int)Enemies[0].Texture2D.Height, Color.Red);
                //foreach (GameObject enemy in Enemies.Where(x => x.CanBeDraw == true))
                //{
                //    Raylib.DrawTexture(enemy.Texture2D, (int)enemy.Position.X, (int)enemy.Position.Y, Color.Brown);
                //}
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
            Console.WriteLine("Hello, World!");
        }
        private void GenerateEnemies(int numberOfEnemiesInRow)
        {
            int posX = 100;
            int posY = 100;

            for (int j = 0; j < numberOfEnemiesInRow; j++)
            {

                posX += 70;
            }


        }

        private bool IsMissileWithinBoard()
        {
            if (playerMissile.Position.Y <= 0)
            {
                playerMissile.WasFired = false;
                return false;
            }
            else
            {
                return true;
            }

        }

        private void LoadGameTexture()
        {
            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);
            path += gameTexturePath;

            if (File.Exists(path))
            {
                gameTexture = Raylib.LoadTexture(path);
            }
        }

        

        public void LaunchPlayerMissile()
        {
            playerMissile.WasFired = true;
            playerMissile.Position = player.Position;
        }

        private void IfMissileHittedEnemy()
        {
            var rangeY = Enemies[0].Position.Y;
            foreach (var enemy in Enemies.Where(x => x.CanBeDraw == true))
            {

                if (playerMissile.Position.Y == rangeY &&
                playerMissile.Position.X >= enemy.Position.X &&
                playerMissile.Position.X <= (enemy.Position.X + enemy.Texture2D.Width)
                )
                {

                    enemy.CanBeDraw = false;
                    break;
                }
            }


        }
    }
}
