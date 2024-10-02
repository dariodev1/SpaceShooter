// See https://aka.ms/new-console-template for more information

using Raylib_cs;
using SpaceShooter.Model;
using SpaceShooter.Model.Abstract;

Raylib.InitWindow(1200, 800, "Hello World");
Player player = new Player();
while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);

    Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Yellow);
    Raylib.DrawTexture(player.Texture2D, 300, 300, Color.Brown);
    Raylib.EndDrawing();
}

Raylib.CloseWindow();
Console.WriteLine("Hello, World!");
