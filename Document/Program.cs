/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте базовый абстрактный класс Document (документ), в котором создайте три метода void
Headline (Заголовок), DocumentСontent (Содержимое документ), Footer (подвал документа).
Реализуйте конкретный класс, который наследуется от производного класса Document, в теле
класса реализуйте все методы абстрактного класса. (Реализация может заключатся в простом
выводе информации о том какая это часть документа.)
*/

Newspaper newsPaper = new();
newsPaper.HeadLine();
newsPaper.DocumentСontent();
newsPaper.Footer();

Console.ReadKey();
abstract class Document
{
    abstract public void HeadLine();
    abstract public void DocumentСontent();
    abstract public void Footer();
}
class Newspaper : Document
{
    public override void HeadLine()
    {
        Console.WriteLine("Это заголовок газеты");
    }
    public override void DocumentСontent()
    {
        Console.WriteLine("Это содержимое газеты");
    }

    public override void Footer()
    {
        Console.WriteLine("Это нижний колонтитул газеты");
    }   
}