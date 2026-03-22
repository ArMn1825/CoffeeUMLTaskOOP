public abstract class Ice : Ingredient
{
    public string Shape { get; set; }
    public Ice(double mass,  string shape = "cube") : base(mass)
    {
        Shape = shape;
    }
    public override string GetInfo() =>
        $"Ice in shape of {Shape} with mass of {Mass} g";
}