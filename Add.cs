using System.Xml.Schema;

public class Add : Action
{
    public Add(List<IElement> ?elements = null) : base(elements) {}
    public Add() : base(null) {}
    public override string GetInfo() => $"PID {Id}: Adding ingredients";
    public override void Execute()
    {
        ExecuteElements();
        CurrentExecutionInfo();
        Console.Out.WriteLine("Adding completed successfully!");
    }
}
