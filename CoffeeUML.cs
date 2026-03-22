using System.Text.Json.Nodes;
public class Program
{
    public static Drink ParseJSONRecipe(string json)
    {
        #nullable disable
        var root = JsonNode.Parse(json);
        return new Drink(CreateElement(root));
        #nullable restore
    }
    
    private static IElement CreateElement(JsonNode node)
    {
        #nullable disable
        string type = node["type"].GetValue<string>();
        switch (type)
        {
            case "water":
                return new Water((double)node["mass"], (double)node["salinity"]);
            case "ice":
                return new Ice((double)node["mass"], node["shape"].GetValue<string>());
            case "coffeebean":
                return new CoffeeBean((double)node["mass"], node["sort"].GetValue<string>());
            case "syrup":
                return new Syrup((double)node["mass"], node["syrup_type"].GetValue<string>());
            case "milk":
                return new Milk((double)node["mass"], (double)node["fat_content"]);
            case "mix":
                return CreateAction<Mix>(node);
            case "pour":
                return CreateAction<Pour>(node);
            case "boil":
                return CreateAction<Boil>(node);
            case "whip":
                return CreateAction<Whip>(node);
            case "grind":
                return CreateAction<Grind>(node);
            case "add":
                return CreateAction<Add>(node);
            default: throw new Exception("Incorrect recipe");
        }
        #nullable restore
    }
    private static Action CreateAction<T>(JsonNode node) where T : Action, new()
    {
        #nullable disable
        var action = new T();
        if (node["elements"] is JsonArray arr)
        {
            foreach (var elem in arr)
            {
                action.Add(CreateElement(elem));
            }
        }
        return action;
        #nullable restore
    }
    public static void Main()
    {
        string recipe = Console.In.ReadToEnd();
        if (recipe != null) {
            Drink drink = ParseJSONRecipe(recipe);
            if (drink.Recipe is Action act)
            {
                Console.Out.WriteLine("Your drink is getting ready:");
                act.Execute();
            }
            else if (drink.Recipe is Ingredient) /* I reaally want to have LiquidIngredient class */
            {
                Console.Out.WriteLine($"Your drink is {drink.Recipe.GetInfo()}");
            }
        }
    }
}
