public abstract class CoffeeBean : Ingredient
{
    public string CoffeeSort { get; set; }
    public CoffeeBean(double mass,  string coffee_sort = "unspecified") : base(mass)
    {
        CoffeeSort = coffee_sort;
    }
    public override string GetInfo() =>
        $"Coffee bean: sort is {CoffeeSort}, mass is {Mass} g";
}
