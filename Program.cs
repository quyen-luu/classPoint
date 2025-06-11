public class Program
{
    public static void Main(string[] args)
    {
        Point2D point2dDefault = new Point2D();
        Console.WriteLine("Point2D:");
        Console.WriteLine(point2dDefault);

        Point2D point2D1 = new Point2D(2, 5.2f);
        Console.WriteLine("Point2D");
        Console.WriteLine(point2D1);

        Point3D point3DDefault = new Point3D();
        Console.WriteLine("Point3D");
        Console.WriteLine(point3DDefault);

        Point3D point3D1 = new Point3D();
        point3D1.SetX(2.5f);
        point3D1.SetY(0.5f);
        point3D1.SetZ(4);
        Console.WriteLine("Point3D");
        Console.WriteLine(point3D1);

    }
}

public class Point2D
{
    private float X;
    private float Y;

    public Point2D()
    {
        X = 0.0f;
        Y = 0.0f;
    }

    public Point2D(float X, float Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public float GetX()
    {
        return X;
    }

    public void SetX(float X)
    {
        this.X = X;
    }

    public float GetY()
    {
        return Y;
    }

    public void SetY(float Y)
    {
        this.Y = Y;
    }

    public void SetXY(float X, float Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public float[] GetXY()
    {
        return new float[2] { X, Y };
    }

    public override string ToString()
    {
        return $"- X: {GetX()}\n" +
               $"- Y: {GetY()}\n" +
               $"- XY: ({string.Join(", ", GetXY())})\n";
    }
}

public class Point3D : Point2D
{
    private float Z;

    public Point3D() : base()
    {
        Z = 0.0f;
    }

    public Point3D(float X, float Y, float Z) : base(X, Y)
    {
        this.Z = Z;
    }

    public float GetZ()
    {
        return Z;
    }
    public void SetZ(float Z)
    {
        this.Z = Z;
    }

    public void SetXYZ(float X, float Y, float Z)
    {
        SetXY(X, Y);
        this.Z = Z;
    }
    public float[] GetXYZ()
    {
        return new float[3] { GetX(), GetY(), Z };
    }

    public override string ToString()
    {
        return $"- X: {GetX()}\n" +
               $"- Y: {GetY()}\n" +
               $"- Z: {GetZ()}\n" +
               $"- XY: ({string.Join(", ", GetXY())})\n" +
               $"- XYZ: ({string.Join(", ", GetXYZ())})\n";
    }
}