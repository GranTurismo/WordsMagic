using System.Diagnostics;

namespace WordsMagic;

public class MatLee
{
    private readonly WordFileTool _wft;
    private List<Mat> _passed = new();
    private string _word = String.Empty;

    public HashSet<string> Words { get; private set; }

    public MatLee(WordFileTool wft)
    {
        _wft = wft;
        Words = new HashSet<string>();
    }

    public void FindWords(List<Mat> mats)
    {
        foreach (Mat item in mats)
        {
            StartFinding(item);
            _passed.Clear();
        }
    }

/*
 *
 * brp
 * gej
 * kke
 */
    private void StartFinding(Mat mat)
    {
        _passed.Add(mat);
        _word = string.Concat(_passed.Select(o => o.Value));
        if (_wft.DoesContainWord(_word))
            Words.Add(_word);
        IEnumerable<Mat> pots = mat.PotentialNextMat.Except(_passed);
        foreach (Mat o in pots)
        {
            StartFinding(o);
            _passed.Remove(o);
        }
    }
}