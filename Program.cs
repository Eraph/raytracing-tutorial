int imageWidth = 256;
int imageHeight = 256;

Console.WriteLine("P3");
Console.WriteLine($"{imageWidth} {imageHeight}");
Console.WriteLine(255);

for (int j = 0; j < imageHeight; j++)
{
    for (int i = 0; i < imageWidth; i++)
    {
        var r = (double)i / (imageWidth - 1);
        var g = (double)j / (imageHeight - 1);
        var b = 0.0;

        int ir = (int)(255.999 * r);
        int ig = (int)(255.999 * g);
        int ib = (int)(255.999 * b);

        Console.WriteLine($"{ir} {ig} {ib}");
    }
}