public class Mix : Action
{
    public Mix(List<IElement> ?elements = null) : base(elements) {}
    public override string GetInfo() => "Mixing ingredients";
    public override void Execute()
    {
        Console.Out.WriteLine("Mixing:\n");
        ExecuteElements();
        Console.Out.WriteLine("Mixing completed successfully.");
    }
}
