using BenchmarkDotNet.Attributes;

namespace WordsMagic;

[MemoryDiagnoser]
public class WordMagicTool
{
    [Params("brpgejkke")]
    public string ProvidedData { get; set; }

    public WordMagicTool()
    {
        
    }

    public WordMagicTool(string data)
    {
        if (!string.IsNullOrEmpty(data))
            ProvidedData = data;
    }

    [Benchmark]
    public HashSet<string> Calculate()
    {
        MatrixMaster master = new(ProvidedData);
        WordFileTool wordFileTool = new();

        MatrixToMatConverter converter = new(master.Matrix);

        List<Mat> mats = converter.Mats;

        MatLee matLee = new MatLee(wordFileTool);
        matLee.FindWords(converter.Mats);

        return matLee.Words;
    }

    void MatrixMasterPrinter<T>(T[,] matrix) where T : struct
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }
}