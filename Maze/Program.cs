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

maze[3][4] = Field.Player;

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