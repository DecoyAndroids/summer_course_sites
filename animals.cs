public class Animal
{
    private string name;
    public Animal(string name)
    {
        this.name = name;
    }
    public void naming()
    {
        Console.WriteLine($"���: {name}");
    }
}
Animal cat = new Animal("����");
cat.naming();