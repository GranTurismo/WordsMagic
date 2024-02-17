namespace WordsMagic;

public class MatrixToMatConverter
{
    public List<Mat> Mats = new List<Mat>();

    public MatrixToMatConverter(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Mats.Add(new Mat(j, i, matrix[i, j]));
            }
        }

        Mats.ForEach(o => o.GeneratePotentialNextMats(Mats));
    }
}