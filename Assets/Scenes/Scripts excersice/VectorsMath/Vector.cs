using UnityEngine;

[System.Serializable]
public class Vector
{
    public float x, y;

    public Vector(float xBit, float yBit)
    {
        x = xBit;
        y = yBit;
    }

    public static Vector operator +(Vector a, Vector b)
    {
        return new Vector(a.x + b.x, a.y + b.y);
    }
    public static Vector operator -(Vector a, Vector b)
    {
        return new Vector(a.x - b.x, a.y - b.y);
    }
    public static Vector operator *(Vector a, float b)
    {
        return new Vector(a.x * b, a.y * b);
    }
    public static Vector operator *(float b, Vector a)
    {
        return new Vector(a.x * b, a.y * b);
    }
    public static Vector operator/(Vector a, float b)
    {
        return new Vector(a.x / b, a.y / b);
    }
    public Vector Lerp(Vector other, float esca)
    {
        Vector result = new Vector((x*(1- esca)+ (other.x*esca)), (y*(1-esca)+ (other.y * esca)));
        return result;
    }
    public float Magni()
    {
        float result = Mathf.Sqrt((x * x) + (y * y));
        return result;
    }
    public Vector Normal()
    {
        float magnitud = Mathf.Sqrt((x * x) + (y * y));
        Vector result = new Vector(x / magnitud, y / magnitud);
        return result;
    }
    public void Draw(Vector origin = null)
    {
        if (origin == null)
        {
            Debug.DrawLine(new Vector2(0, 0), new Vector2(x, y));
            return;
        }
        Debug.DrawLine(new Vector2(origin.x, origin.y), new Vector2(x + origin.x, y + origin.y));
    }
}
