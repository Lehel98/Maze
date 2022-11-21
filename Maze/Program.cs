using Maze;

List<List<Field>> maze = new List<List<Field>>();

for (Int32 i = 0; i < 20; ++i)
{
    maze.Add(new List<Field>());
    for (Int32 j = 0; j < 60; ++j)
    {
        if (i == 0 || i == 19 || j == 0 || j == 59)
            maze[i].Add(Field.Wall);
        else
            maze[i].Add(Field.Corridor);
    }
}

Int32 PlayerX = 3, PlayerY = 4;

maze[PlayerX][PlayerY] = Field.Player;

for (Int32 i = 0; i < 20; ++i)
{    
    for (Int32 j = 0; j < 60; ++j)
    {
        switch (maze[i][j])
        {
            case Field.Player:
                Console.Write("O");
                break;
            case Field.Corridor:
                Console.Write(" ");
                break;
            case Field.Wall:
                Console.Write("#");
                break;
        }
    }
    Console.WriteLine();
}

Boolean Escape = false;

while (!Escape)
{
    ConsoleKeyInfo key = Console.ReadKey();

    Console.WriteLine(key.Key.ToString());

    Int32 x = PlayerX, y = PlayerY;

    switch (key.Key.ToString().ToUpper())
    {
        case "W":
            x = PlayerX - 1;
            y = PlayerY;
            break;
        case "A":
            x = PlayerX;
            y = PlayerY - 1;
            break;
        case "S":
            x = PlayerX + 1;
            y = PlayerY;
            break;
        case "D":
            x = PlayerX;
            y = PlayerY + 1;
            break;
        case "ESCAPE":
            Escape = true;
            break;
    }

    if (x >= 0 && x <= 19 && y >= 0 && y <= 59 && maze[x][y] != Field.Wall)
    {
        maze[PlayerX][PlayerY] = Field.Corridor;
        maze[x][y] = Field.Player;
        PlayerX = x;
        PlayerY = y;
    }

    Console.Clear();

    for (Int32 i = 0; i < 20; ++i)
    {
        for (Int32 j = 0; j < 60; ++j)
        {
            switch (maze[i][j])
            {
                case Field.Player:
                    Console.Write("O");
                    break;
                case Field.Corridor:
                    Console.Write(" ");
                    break;
                case Field.Wall:
                    Console.Write("#");
                    break;
            }
        }
        Console.WriteLine();
    }
}
