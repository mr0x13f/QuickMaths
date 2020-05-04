namespace Quickmaths {

// This only exists to not have to manually cast everything from System.Math to a float

public static class Math {

    public static readonly float PI = (float) System.Math.PI;

    public static float abs(float n) => (float) System.Math.Abs(n);
    public static float max(float a, float b) => (float) System.Math.Max(a, b);
    public static float min(float a, float b) => (float) System.Math.Min(a, b);
    public static float clamp(float n, float min, float max) => (float) System.Math.Clamp(n, min, max);
    public static float floor(float n) => (float) System.Math.Floor(n);
    public static float ceil(float n) => (float) System.Math.Ceiling(n);
    public static float round(float n) => (float) System.Math.Round(n);

    public static float pow(float x, float y) => (float) System.Math.Pow(x,y);
    public static float exp(float n) => (float) System.Math.Exp(n);
    public static float log(float x) => (float) System.Math.Log(x);
    public static float log(float x, float y) => (float) System.Math.Log(x, y);
    public static float sqrt(float n) => (float) System.Math.Sqrt(n);

    public static float sin(float a) => (float) System.Math.Sin(a);
    public static float asin(float n) => (float) System.Math.Asin(n);
    public static float cos(float a) => (float) System.Math.Cos(a);
    public static float acos(float n) => (float) System.Math.Acos(n);
    public static float tan(float a) => (float) System.Math.Tan(a);
    public static float atan(float n) => (float) System.Math.Atan(n);
    public static float atan2(float y, float x) => (float) System.Math.Atan2(y, x);

}
}