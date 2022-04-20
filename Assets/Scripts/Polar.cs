using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polar : MonoBehaviour {

    [SerializeField] float Thetha, Radius,radialSpeed, angularSpeed,angularAccel,radialAccel;
    [SerializeField] Vector2 polarCoord;
    [SerializeField] GameObject bomba;
    [SerializeField] float rMax;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        CheckCollisions();
        bomba.transform.position = PolarToCartesian(polarCoord);
        radialSpeed += radialAccel * Time.deltaTime;
        angularSpeed += angularAccel * Time.deltaTime;
        polarCoord.y += angularSpeed*Time.deltaTime;
        polarCoord.x += radialSpeed*Time.deltaTime;
        DrawPolar(polarCoord);
	}
    private void DrawPolar(Vector2 polarCoord)
    {

        Vector3 cartesian = PolarToCartesian(polarCoord);
        Debug.DrawLine(Vector3.zero, cartesian, Color.blue);
    }
    private Vector3 PolarToCartesian (Vector2 polar)
    {
        float r = polarCoord.x;
        float cos = Mathf.Cos(polarCoord.y);
        float sin = Mathf.Sin(polarCoord.y);
        Vector3 cartesian = new Vector3(r*cos, r*sin);
        
       
        return cartesian;
    }
    private void CheckCollisions()
    {

        if (polarCoord.x >= rMax)
        {
            radialSpeed = -radialSpeed;
        }
        if (polarCoord.x == 0)
        {
            radialSpeed = -radialSpeed;
        }
    }
}
