// Board Class
// Contains all information about a board state

public class Stone
{
    private int color;
    private int x;
    private int y;


    public Stone(int paramX, int paramY, string paramColor)
    {
        x = paramX;
        y = paramY;

        if (paramColor == "black")
            color = 1;
        else if (paramColor == "white")
            color = 2;
        else
            color = 0;
    }

    public string getColor()
    {
        if (color == 1)
            return "black";
        if (color == 2)
            return "white";

        return "empty";
    }
}