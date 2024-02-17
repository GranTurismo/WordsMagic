namespace WordsMagic;

public class MatrixMaster
{
    public char[,] Matrix { get; }
    
    public MatrixMaster(string rawData)
    {
        int length = (int)Math.Sqrt(rawData.Length);
        Matrix = new char[length, length];

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Matrix[i, j] = rawData[i * length + j];
            }
        }
    }
}