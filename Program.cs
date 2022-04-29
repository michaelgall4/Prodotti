
using FileProductH;

var fileProductH = new HelperO("C:\\PDO.csv.txt");

var PDO = fileProductH.ReadAllProdottiDaOrdinare();

Console.WriteLine("*********************");

foreach (var prodottiDaOrdinare in PDO)
{
    Console.WriteLine($"Id prodotto: {prodottiDaOrdinare.ProdottoIdO} - Nome prodotto: {prodottiDaOrdinare.NomeProdottoO} - Quantità: {prodottiDaOrdinare.QuantitaO}");
}

Console.WriteLine("*********************");

Console.WriteLine("Inserire Id prodotto");
var prodottoIdO = Console.ReadLine();
Console.WriteLine("Inserire il nome del prodotto");
var nomeProdottoO = Console.ReadLine();
Console.WriteLine("Inserire la quantità");
var quantitaO = Console.ReadLine();

var prodottiDaOrdinarenew = new ProdottiDaOrdinare();
prodottiDaOrdinarenew.ProdottoIdO = prodottoIdO;
prodottiDaOrdinarenew.NomeProdottoO = nomeProdottoO;
prodottiDaOrdinarenew.QuantitaO = quantitaO;

fileProductH.AddProdottiDaOrdinare(prodottiDaOrdinarenew);

PDO = fileProductH.ReadAllProdottiDaOrdinare();


Console.WriteLine("*********************");

foreach (var contact in PDO)
{
    Console.WriteLine($"Id prodotto: {prodottiDaOrdinarenew.ProdottoIdO} - nome prodotto: {prodottiDaOrdinarenew.NomeProdottoO} - quantità: {prodottiDaOrdinarenew.QuantitaO}");
}

Console.WriteLine("*********************");


Console.ReadLine();