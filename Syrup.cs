public abstract class Syrup : Ingredient
{
    public string SyrupType { get; set; }
    public Syrup(double mass,  string syrup_type) : base(mass)
    {
        SyrupType = syrup_type;
    }
    public override string GetInfo() =>
        $"Syrup: {SyrupType}, mass is {Mass} g";
}
