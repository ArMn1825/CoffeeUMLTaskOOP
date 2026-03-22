public class Mix : Action
{
    public Mix(List<IElement> ?elements = null) : base(elements) {}
    public Mix() : base(null) {}
    public override string GetInfo() => "Mixing ingredients";
    public override void Execute()
    {
        Console.Out.WriteLine("\nMixing:");
        ExecuteElements();
        Console.Out.WriteLine("Mixing completed successfully!");
    }
}
