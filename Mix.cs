public class Mix : Action
{
    public Mix(List<IElement> ?elements = null) : base(elements) {}
    public Mix() : base(null) {}
    public override string GetInfo() => $"PID {Id}: Mixing ingredients";
    public override void Execute()
    {
        ExecuteElements();
        CurrentExecutionInfo();
        Console.Out.WriteLine("Mixing completed successfully!");
    }
}
