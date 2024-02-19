/*
* Scrietiun program care citind de la tastaura
* cele trei dimensiuni ale unui paralelipiped dreptunghic,
* va afisavolumul lui
*/


Console.WriteLine("Introduceti valoarea pentru latura a");
int laturaA = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentru latura b");
int laturaB = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentru latura c");
int laturaC = int.Parse(Console.ReadLine());

//Volum = laturaA * laturaB * laturaC
int volumulParalelipipeduluiDreptunghic = laturaA * laturaB * laturaC;

Console.WriteLine("Volumul paralelipepedului dreptunghic este:" + volumulParalelipipeduluiDreptunghic);