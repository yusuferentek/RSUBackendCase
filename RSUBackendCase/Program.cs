using RSUBackendCase.Model;
using RSUBackendCase.Services;

// yüzey sınırılarının belirlenmesi
Console.WriteLine("Lütfen Yüzey Boyutlarını Giriniz: ");
var gridSize = Console.ReadLine().Split();
int maxX = int.Parse(gridSize[0]);
int maxY = int.Parse(gridSize[1]);

var grid = new Grid(maxX, maxY);


//İlk gezginin verilerinin belirlenmesi
Console.WriteLine("Lütfen İlk Gezgine ait koordinat bilgisini giriniz: ");
var initialPosition1 = Console.ReadLine().Split();
int x1 = int.Parse(initialPosition1[0]);
int y1 = int.Parse(initialPosition1[1]);
DirectionEnum direction1 = (DirectionEnum)Enum.Parse(typeof(DirectionEnum), initialPosition1[2]);

var rover1 = new Rover(x1, y1, direction1, grid);
var controller1 = new RoverController(rover1);
Console.WriteLine("İlk Gezgine ait Komutları birleşik olarak giriniz(L-M-R): ");
string commands1 = Console.ReadLine();
controller1.ExecuteCommands(commands1);
Console.WriteLine(rover1);


// İkinci gezginin verileriniN belirlenmesi
var initialPosition2 = Console.ReadLine().Split();
int x2 = int.Parse(initialPosition2[0]);
int y2 = int.Parse(initialPosition2[1]);
DirectionEnum direction2 = (DirectionEnum)Enum.Parse(typeof(DirectionEnum), initialPosition2[2]);

var rover2 = new Rover(x2, y2, direction2, grid);
var controller2 = new RoverController(rover2);
Console.WriteLine("İkinci Gezgine ait Komutları birleşik olarak giriniz(L-M-R): ");
string commands2 = Console.ReadLine();
controller2.ExecuteCommands(commands2);
Console.WriteLine(rover2);