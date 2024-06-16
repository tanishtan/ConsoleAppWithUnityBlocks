using Unity;
using ConsoleAppWithUnityBlocks;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections;

/*
var container = Bootstraper.Initialize();

var serviceObj = container.Resolve<ServiceDependentClass>();
serviceObj.Start();

Console.WriteLine();
serviceObj.StartProperty();
Console.WriteLine();
serviceObj.StartWithInjection();*/
/*
var serviceObj2 = container.Resolve<ServiceDependentClass>();
serviceObj2.Start();

var obj = container.Resolve<AddOnClassForCircularDependancy>();
obj.StartNew();*/



//Tuples
var tuple = (10, "Name", "blor");
tuple.Item1 = 999;
Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");

(int Number, string Name, string location)tuple2 = (999, "Main", "Chennai");
Console.WriteLine($"{tuple2.Name}, {tuple2.location}");

static (int No, string name) GetData()
{
    return (200, "scu");
}
var status = GetData();
Console.WriteLine($"{status.name}, {status.No}");

Sample s = new Sample() { Prop1 = 123, Prop2 = 321, Prop3 = "Test Data" };
var num1 = s.Prop1;
var text = s.Prop3;
Console.WriteLine(num1);
Console.WriteLine(text);


//Deconstructing objects
(int p1, int p2, string p3) = s;
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

object x = s;
if(x is Sample)
{
    var s1 = x as Sample;
    Console.WriteLine(s1);
}
if(x is Sample s2)// Type pattern matching
{
    Console.WriteLine(s2);
}

switch (s)
{
    case Sample when (s.Prop1>0 && s.Prop2>400): Console.WriteLine("Case 1");break;
    case Sample when (string.IsNullOrEmpty(s.Prop3)): Console.WriteLine("Case 2");break;
    case Sample when (!string.IsNullOrEmpty(s.Prop3)): Console.WriteLine("Case 3"); break;
    case null:
        Console.WriteLine("case null");break;
    default:
        Console.WriteLine("case defualt");break;
}

public class Sample
{
    public int Prop1 { get; set; }
    public int Prop2 { get; set; }
    public string? Prop3 { get; set; }

    public void Deconstruct(out int p1, out int p2, out string p3)
    {
        p1 = Prop1;
        p2= Prop2;
        p3 = Prop3;
    }
}






