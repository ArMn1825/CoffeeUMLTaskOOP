public abstract class Milk : Ingredient
{
    private const double DENSITY = 1;
    private double _fat_content;
    public double FatContent
    {
        get => _fat_content;
        set
        {
            _fat_content = value > 100 ? 100 : value < 0 ? 0 : value;
        }
    }
    public Milk(double mass,  double fat_content) : base(mass)
    {
        FatContent = fat_content;
    }
    public override string GetInfo() =>
        $"Milk: volume is {Mass / DENSITY} ml, fat content is {FatContent}%";
}
