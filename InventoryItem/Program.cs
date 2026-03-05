using System;

InventoryItem[] inventoryItems = new InventoryItem[5] {
    new InventoryItem("검", 3.5, 1500),
    new InventoryItem("방패", 5, 1200),
    new InventoryItem("포션", 0.3, 50),
    new InventoryItem("활", 1.8, 1300),
    new InventoryItem("투구", 2, 800)
};

double totalWeight = 0;
int totalPrice = 0;

string maxPriceItemName = "";
int maxPrice = int.MinValue;

string minWeightItemName = "";
double minWeight = double.MaxValue;

Console.WriteLine("=== 인벤토리 목록 ===");
foreach(InventoryItem item in inventoryItems)
{
    Console.WriteLine(item);
    totalPrice += item.Price;
    totalWeight += item.Weight;

    if(item.Price > maxPrice)
    {
        maxPrice = item.Price;
        maxPriceItemName = item.Name;
    }

    if(item.Weight < minWeight)
    {
        minWeight = item.Weight;
        minWeightItemName = item.Name;
    }
}

Console.WriteLine($"=== 인벤토리 통계 ===");
Console.WriteLine($"전체 무게: {totalWeight:F1}kg");
Console.WriteLine($"전체 가격: {totalPrice}골드");
Console.WriteLine($"평균 가격: {totalPrice/inventoryItems.Length}골드");
Console.WriteLine($"가장 비싼 아이템: {maxPriceItemName}");
Console.WriteLine($"가장 가벼운 아이템: {minWeightItemName}");
