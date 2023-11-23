using Projecting;

Random random = new Random();

List<int>listaNumeriCasuali = Enumerable.Range(1, 100).Select(r => random.Next(1, 1000)).ToList();

List<NumberMetaData> listaIstanzeClasse = listaNumeriCasuali.Select(numero => new NumberMetaData(numero)).ToList();

foreach(var elemento in listaIstanzeClasse)
{
    Console.WriteLine($"IsEven: {elemento.IsEven}, NumberOfCharacters: {elemento.NumberOfCharacters}");
}