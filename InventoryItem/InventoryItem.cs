struct InventoryItem
{
    public string Name;
    public double Weight;
    public int Price;

    public InventoryItem(string name, double weight, int price)
    {
        Name = name;
        Weight = weight;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - 무게: {Weight}kg, 가격: {Price}골드";
    }
}