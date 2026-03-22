public class Add : Action
{
    public Add(List<IElement> ?elements = null) : base(elements) {}
    public Add() : base(null) {}
    public override string GetInfo() => "Adding ingredients";
    public override void Execute()
    {
        Console.Out.WriteLine("Adding:\n");
        ExecuteElements();
        Console.Out.WriteLine("Adding completed successfully!");
    }
}
