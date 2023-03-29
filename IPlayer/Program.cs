/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте два интерфейса IPlayable и IRecodable. В каждом из
интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void
Pause() / void Stop() соответственно. Создайте производный класс Player от базовых интерфейсов
IPlayable и IRecodable. Написать программу, которая выполняет проигрывание и запись.
*/

Console.WriteLine("Выберите действие с музыкальным плеером: ");
Console.WriteLine("1. Воспроизвести трек");
Console.WriteLine("2. Начать запись");

int operation = int.Parse(Console.ReadLine());

Player musicPlayer = new();

if (operation == 1)
{
    musicPlayer.Play();
    int nextOperation = int.Parse(Console.ReadLine());
    switch (nextOperation)
    {
        case 1:
            musicPlayer.Pause();
            break;
        case 2:
            musicPlayer.Stop();
            break;
        default:
            break;
    }
}

if (operation == 2)
{
    musicPlayer.Record();
    int nextOperation = int.Parse(Console.ReadLine());
    switch (nextOperation)
    {
        case 1:
            musicPlayer.Pause();
            break;
        case 2:
            musicPlayer.Stop();
            break;
        default:
            break;
    }
}

Console.ReadKey();

interface IPlayable
{
    void Play();
    void Pause();
    void Stop();
}

interface IRecordable
{
    void Record();
    void Pause();
    void Stop();
}

class Player : IPlayable, IRecordable
{
    public void Play()
    {
        Console.WriteLine("Трек проигрывается...");
        Console.WriteLine("1. Приостановить воспроизведение");
        Console.WriteLine("2. Остановить воспроизведение");
    }
    public void Record()
    {
        Console.WriteLine("Запись начата...");
        Console.WriteLine("1. Приостановить запись");
        Console.WriteLine("2. Остановить запись");
    }
    public void Pause()
    {
        Console.WriteLine("Воспроизведение и запись приостановлены");
    }
    public void Stop()
    {
        Console.WriteLine("Воспроизведение и запись завершены");
    }   
}