using BenchmarkDotNet.Running;
using WordsMagic;

Console.WriteLine("Provided Raw Data:"); 
//string testData = "fitcehosbnaohormuatcmldoesnernomuniolecamiatlldentcbztoaslaielivrncexonlevoekamsa";

  
string testData = "brpgejkke";

/*WordMagicTool t = new WordMagicTool(testData);
    HashSet<string> words = t.Calculate();
Console.WriteLine(words.Count);*/
BenchmarkRunner.Run<WordMagicTool>();

Console.ReadLine();