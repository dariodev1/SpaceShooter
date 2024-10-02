using Raylib_cs;
using SpaceShooter.Model;

namespace SpaceShooter
{
    internal class Game
    {
        public Game() 
        {
            Raylib.InitWindow(1200, 800, "Hello World");
            Player player = new Player();
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Yellow);
                Raylib.DrawTexture(player.Texture2D, (int)player.Position.X, (int)player.Position.Y, Color.Brown);
                if (Raylib.IsKeyPressed(KeyboardKey.Right) || Raylib.IsKeyPressedRepeat(KeyboardKey.Right))
                {
                    player.Move(Direction.Right);
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.Left) || Raylib.IsKeyPressedRepeat(KeyboardKey.Left))
                {
                    player.Move(Direction.Left);
                }
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
            Console.WriteLine("Hello, World!");
        }
    }
}
