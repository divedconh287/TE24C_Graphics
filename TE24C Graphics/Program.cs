using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 600, "Hej TE24C");
Raylib.SetTargetFPS(60);

Texture2D booltruetruefalse = Raylib.LoadTexture("booltrue.png");

Rectangle booltruetruefalserect = new(
400, 300, booltruetruefalse.Dimensions
);

Vector2 pos = new(400, 300);
// 2 = 2 dimensionell vektor
float speed = 4;
// hastighet

while (!Raylib.WindowShouldClose())
// while(Raylib.WindowShouldClose() == false)
{
    // [ pos.X += 1;
    // lägger till 1 pixel till x axeln 60 ggr per sekund (eftersom i while) ]

    // if (Raylib.IsKeyDown(KeyboardKey.Right)) pos.X += speed; 
    // måsvinge behövs inte om det bara är en ;
    // hålls tangenten ned?
    // {
    //     pos.X += 1;
    // }

    // if (Raylib.IsKeyDown(KeyboardKey.Left)) pos.X -= speed;
    // if (Raylib.IsKeyDown(KeyboardKey.Down)) pos.Y += speed;
    // if (Raylib.IsKeyDown(KeyboardKey.Up)) pos.Y -= speed;
    // samma fast andra hållet

        if (Raylib.IsKeyDown(KeyboardKey.Right)) booltruetruefalserect.X += speed;   
        if (Raylib.IsKeyDown(KeyboardKey.Left)) booltruetruefalserect.X -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.Down)) booltruetruefalserect.Y += speed;
        if (Raylib.IsKeyDown(KeyboardKey.Up)) booltruetruefalserect.Y -= speed;

            if (booltruetruefalserect.X < 0) booltruetruefalserect.X += speed;
            if (booltruetruefalserect.X + booltruetruefalserect.Width > 800) booltruetruefalserect.X -= speed;
            if (booltruetruefalserect.Y < 0) booltruetruefalserect.Y += speed;
            if (booltruetruefalserect.Y + booltruetruefalserect.Height > 600) booltruetruefalserect.Y -= speed;
            
                

    Raylib.BeginDrawing();
    // förbereder, ritar

    Raylib.ClearBackground(Color.Pink);
    Raylib.DrawCircleV(pos, 100, Color.Black);
    // Raylib.DrawCircle(200, 200, 100, Color.Black);
    // de övre två är samma

    // Raylib.DrawCircle(400, 300, 50, Color.Black);

    Raylib.DrawTextureV(booltruetruefalse, position, Color.White);

    Raylib.EndDrawing();
    // "flippar" byter
}// Raylib har två bitar minne, varje har 800 ggr 600 pixelarrayer, en ritas ut till användaren, den osynliga ritas i innan Raylib.EndDrawing(); & efter så byts dem och den osynlige rensas, kallas double buffering, likt tearing i spel, 

// gamla skärmar (CRT) ritade linje för linje upp till ned, därför är Origo i högst upp i vänstra hörnet & rör sig åt höger