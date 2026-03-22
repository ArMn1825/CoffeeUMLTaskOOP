public class Water : Ingredient
{
    private const double DENSITY = 1;
    private double _salinity;
    public double Salinity
    {
        get => _salinity;
        set
        {
            _salinity = value >= 0 ? value : 0;
        }
    }
    public Water(double mass, double salinity) : base(mass)
    {
        Salinity = salinity;
    }
    public override string GetInfo() =>
        $"Water: volume is {Mass / DENSITY} ml, salinity is {Salinity} ppm";
}
