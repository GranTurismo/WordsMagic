namespace WordsMagic;

public class Mat
{
    public Mat(int x, int y, char value)
    {
        X = x;
        Y = y;
        Value = value;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public char Value { get; set; }
    public List<Mat> PotentialNextMat { get; set; }

    public void GeneratePotentialNextMats(List<Mat> mats)
    {
        PotentialNextMat = mats
            .Where(o=>IsPotentialNextMat(o)).ToList();
    }

    private bool IsPotentialNextMat(Mat mat)
    {
        if ((mat.X == X - 1 || mat.X == X || mat.X == X + 1) && (mat.Y == Y || mat.Y == Y - 1 || mat.Y == Y + 1) &&
            !(mat.X == X && mat.Y == Y))
            return true;
        return false;
    }
}