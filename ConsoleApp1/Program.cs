/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте интерфейс Printable, содержащий метод void print().
Далее создайте класс Book, класс Journal (журнал) реализующий интерфейс Printable. создайте
класс Magazine, реализующий интерфейс Printable. После создайте массив типа Printable,
который будет содержать книги и журналы и в цикле пройти по массиву и вызвать
метод print() для каждого объекта. Создать метод printMagazines(Printable[] printable) в
классе Magazine, который выводит на консоль названия только журналов. Создать
метод printBooks(Printable[] printable) в классе Book, который выводит на консоль названия
только книг.
*/

IPrintable[] printable = new IPrintable[3];
printable[0] = new Book();
printable[1] = new Journal();
printable[2] = new Magazine();

foreach (var item in printable)
{
    item.Print();
}

Book book = new();
book.PrintBooks(printable);

Magazine magazine = new();
magazine.PrintMagazines(printable);

Console.ReadKey();

interface IPrintable
{
    void Print();
}

class Book : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Book");
    }

    public void PrintBooks(IPrintable[] printable)
    {
        Console.WriteLine("Books: " + printable[0]);
    }
}

class Journal : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Journals");
    }
}

class Magazine : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Magazine");
    }

    public void PrintMagazines(IPrintable[] printable)
    {
        Console.WriteLine("Magazines: " + printable[2]);
    }
}

