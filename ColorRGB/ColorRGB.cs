struct ColorRGB
{
    public int R;
    public int G;
    public int B;

    public int GetBrightness()
    {
        return (R + G + B) / 3;
    }
}