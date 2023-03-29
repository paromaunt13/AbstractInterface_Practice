/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте класс AbstractHandler. В теле класса создать методы
void Open(), void Create(), void Chenge(), void Save(). Создать производные классы XMLHandler,
TXTHandler, DOCHandler от базового класса AbstractHandler. Написать логику, которая будет
выполнять определение документа и для каждого формата должны быть методы открытия,
создания, редактирования, сохранения определенного формата документа.
*/
Console.WriteLine("Выберите тип файла:");
Console.WriteLine("1. XML");
Console.WriteLine("2. TXT");
Console.WriteLine("3. DOC");

int fileType = int.Parse(Console.ReadLine());
void OperationInfo()
{
    Console.WriteLine("Выберите действие с файлом:");
    Console.WriteLine("1. Открыть");
    Console.WriteLine("2. Создать");
    Console.WriteLine("3. Отредактировать");
    Console.WriteLine("4. Сохранить");
}

XMLHandler xml = new();
TXTHandler txt = new();
DOCHandler doc = new();

if (fileType == 1)
{
    OperationInfo();
    int actionOperation = int.Parse(Console.ReadLine());
    switch (actionOperation)
    {
        case 1:
            xml.Open();
            break;
        case 2:
            xml.Create();
            break;
        case 3:
            xml.Change();
            break;
        case 4:
            xml.Save();
            break;
        default: Console.WriteLine("Действие не определено");
            break;
    }
}
if (fileType == 2)
{
    OperationInfo();
    int actionOperation = int.Parse(Console.ReadLine());
    switch (actionOperation)
    {
        case 1:
            txt.Open();
            break;
        case 2:
            txt.Create();
            break;
        case 3:
            txt.Change();
            break;
        case 4:
            txt.Save();
            break;
        default:
            Console.WriteLine("Действие не определено");
            break;
    }
}
if (fileType == 3)
{
    OperationInfo();
    int actionOperation = int.Parse(Console.ReadLine());
    switch (actionOperation)
    {
        case 1:
            doc.Open();
            break;
        case 2:
            doc.Create();
            break;
        case 3:
            doc.Change();
            break;
        case 4:
            doc.Save();
            break;
        default:
            Console.WriteLine("Действие не определено");
            break;
    }
}

Console.ReadKey();
abstract class AbstractHandler
{
    abstract public void Open();
    abstract public void Create();
    abstract public void Change();
    abstract public void Save();
}
class XMLHandler : AbstractHandler
{
    public override void Open()
    {
        Console.WriteLine("XML-файл открыт");
    }
    public override void Create()
    {
        Console.WriteLine("XML-файл создан");
    }
    public override void Change()
    {
        Console.WriteLine("XML-файл отредактирован");
    }     
    public override void Save()
    {
        Console.WriteLine("XML-файл сохранен");
    }
}
class TXTHandler : AbstractHandler
{
    public override void Open()
    {
        Console.WriteLine("TXT-файл открыт");
    }
    public override void Create()
    {
        Console.WriteLine("TXT-файл создан");
    }
    public override void Change()
    {
        Console.WriteLine("TXT-файл отредактирован");
    }
    public override void Save()
    {
        Console.WriteLine("TXT-файл сохранен");
    }
}
class DOCHandler : AbstractHandler
{
    public override void Open()
    {
        Console.WriteLine("DOC-файл открыт");
    }
    public override void Create()
    {
        Console.WriteLine("DOC-файл создан");
    }
    public override void Change()
    {
        Console.WriteLine("DOC-файл отредактирован");
    }
    public override void Save()
    {
        Console.WriteLine("DOC-файл сохранен");
    }
}