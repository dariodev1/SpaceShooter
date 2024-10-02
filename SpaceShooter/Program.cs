// See https://aka.ms/new-console-template for more information

using Raylib_cs;
using SpaceShooter.Model;

Raylib.InitWindow(3640, 2200, "Hello World");
Player player = new Player();
while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);

    Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);
    Raylib.DrawTexture(player.Texture2D, 300, 300, Color.Black);
    Raylib.EndDrawing();
}

Raylib.CloseWindow();
Console.WriteLine("Hello, World!");
