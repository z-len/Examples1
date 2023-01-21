Console.Clear();


// Определяем вершины треугольника:
int xa = 40, ya = 1,
    xb = 1, yb = 20,
    xc = 80, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = yb;
int count = 0;
while (count < 10000)
{
    int z = new Random().Next(0, 3);
    if(z==0)
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
    }
    if(z==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
    if(z==2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    
    count = count+1;

}




// Это рисование домика
// Console.SetCursorPosition(14,2);
// Console.WriteLine("+");
// Console.SetCursorPosition(12,3);
// Console.WriteLine("+");
// Console.SetCursorPosition(16,3);
// Console.WriteLine("+");
// Console.SetCursorPosition(10,4);//с помощью этой команды мы можем ставить точки, отступая от левого и верхнего края
// Console.WriteLine("+");
// Console.SetCursorPosition(10,5);
// Console.WriteLine("+");
// Console.SetCursorPosition(10,6);
// Console.WriteLine("+");
// Console.SetCursorPosition(10,7);
// Console.WriteLine("+");
// Console.SetCursorPosition(10,8);
// Console.WriteLine("+");

// Console.SetCursorPosition(12,8);
// Console.WriteLine("+");
// Console.SetCursorPosition(14,8);
// Console.WriteLine("+");
// Console.SetCursorPosition(16,8);
// Console.WriteLine("+");
// Console.SetCursorPosition(18,8);
// Console.WriteLine("+");

// Console.SetCursorPosition(12,4);
// Console.WriteLine("+");
// Console.SetCursorPosition(14,4);
// Console.WriteLine("+");
// Console.SetCursorPosition(16,4);
// Console.WriteLine("+");
// Console.SetCursorPosition(18,4);
// Console.WriteLine("+");

// Console.SetCursorPosition(18,5);
// Console.WriteLine("+");
// Console.SetCursorPosition(18,6);
// Console.WriteLine("+");
// Console.SetCursorPosition(18,7);
// Console.WriteLine("+");
// Console.SetCursorPosition(18,8);
// Console.WriteLine("+");

