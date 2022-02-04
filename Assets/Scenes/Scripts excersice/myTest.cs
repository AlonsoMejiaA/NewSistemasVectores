using UnityEngine;

public class myTest : MonoBehaviour
{
    [SerializeField]Vector vector1 = new Vector(2, 2);
    [SerializeField]Vector vector2 = new Vector(-1, 3);
    [SerializeField][Range(0,1)] float escalarEscalado = 1;
    Vector vectorSum;
    Vector vectorSub;
    Vector vectorMulti;
    Vector vector1Nor;
    Vector vector2Nor;
    float magnitud1, magnitud2;
    void Start()
    {

        
        //vectorMulti = vector2.Multi(3);
        //magnitud1 = vector1.Magni();
        //magnitud2 = vector2.Magni();
        //vector1Nor = vector1.Normal();
        //vector2Nor = vector2.Normal();

        //Debug.Log("Magnitud vector 1 es: " + magnitud1);
        //Debug.Log("Magnitud vector 2 es: " + magnitud2);
    }

    private void Update()
    {

        vectorSum = vector1 + vector2;
        vectorSub = vector1-vector2;
        var vectorScale = vectorSub * escalarEscalado;
        vector1.Draw();
        vector2.Draw();
        //vectorSum.Draw(vector1);
        vectorScale.Draw(vector2);

        //vector1Nor.Draw();
        //vector2Nor.Draw();
    }
}
