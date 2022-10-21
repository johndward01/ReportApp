


var path = @"C:\Users\johnd\Desktop\dummy data\SampleFile.txt";

var file = File.ReadAllLines(path);

var record = file[1].Take(4);

foreach (var letter in record)
{
    Console.Write($"{letter}");
}
