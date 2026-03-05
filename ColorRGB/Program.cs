using System;


ColorRGB color1 = new ColorRGB()
{
    R = 255,
    G = 0,
    B = 0
};

ColorRGB color2 = new ColorRGB()
{
    R = 255,
    G = 255,
    B = 255
};

ColorRGB color3 = new ColorRGB()
{
    R = 100,
    G = 150,
    B = 200
};


Console.WriteLine("=== RGB 색상 밝기 계산 ===");
Console.WriteLine($"빨강 - R: {color1.R}, G: {color1.G}, B: {color1.B} → 밝기: {color1.GetBrightness()}");
Console.WriteLine($"흰색 - R: {color2.R}, G: {color2.G}, B: {color2.B} → 밝기: {color2.GetBrightness()}");
Console.WriteLine($"커스텀 - R: {color3.R}, G: {color3.G}, B: {color3.B} → 밝기: {color3.GetBrightness()}");
