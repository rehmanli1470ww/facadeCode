#nullable disable
namespace Facade;


interface IDetail
{
    string Trough { get; set; }
    string Size { get; set; }
    void Start();
}


class Wheel : IDetail
{
    public string Trough { get ; set; }
    public string Size { get; set; }

    public void Start()
    {
        Console.WriteLine(" Wheel ");
    }
}

class Frame : IDetail
{
    public string Trough { get; set; }
    public string Size { get; set; }

    public void Start()
    {
        Console.WriteLine(" Frame ");
    }
}

class Steering : IDetail
{
    public string Trough { get; set; }
    public string Size { get; set; }

    public void Start()
    {
        Console.WriteLine(" Steering ");
    }
}

class Pedal : IDetail
{
    public string Trough { get; set; }
    public string Size { get; set; }

    public void Start()
    {
        Console.WriteLine(" Pedal ");
    }
}

class Luggage : IDetail
{
    public string Trough { get; set; }
    public string Size { get; set; }

    public void Start()
    {
        Console.WriteLine(" Luggage ");
    }
}


class Bicycle : IDetail
{
    public List<IDetail> Detail { get; set; } = new();
    public string Trough { get; set ; }
    public string Size { get; set; }

    public void AddDetail(IDetail _otherdevice)
    {
        Detail.Add(_otherdevice);
    }

    
    public void Start()
    {
        Detail.ForEach(e => e.Start());
        Console.WriteLine("The bike is ready");
    }
}




class BicycleFacade
{
    Wheel whell; 
    Frame frame ;
    Steering steering;
    Pedal pedal ;
    Luggage luggage ;
    Bicycle bicycle;

    public BicycleFacade()
    {
        whell = new Wheel();
        frame = new Frame();
        steering = new Steering();
        pedal = new Pedal();
        luggage = new Luggage();
        bicycle = new Bicycle();
        bicycle.AddDetail(whell);
        bicycle.AddDetail(frame);
        bicycle.AddDetail(steering);
        bicycle.AddDetail(pedal);
        bicycle.AddDetail(luggage);
    }

    public void FacadeStart()
    {
        bicycle.Start();
    }
}



class Program
{
    static void Main()
    {
        BicycleFacade factory = new BicycleFacade();
        factory.FacadeStart();
    }
}