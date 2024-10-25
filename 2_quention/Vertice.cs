

namespace _2_quention;

public class Vertice
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Vertice(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int x, int y)
    {
        X = x; 
        Y = y;
    }
}

