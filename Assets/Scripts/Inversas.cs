using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inversas : MonoBehaviour {


    Vector3 dif;
	void Update ()
    {
        
        Vector3 mousePos = GetWorldMousePosition();
       
        dif = mousePos - transform.position;
        float radians = Mathf.Atan2(dif.y, dif.x);
        transform.localRotation = Quaternion.Euler(0f, 0f, radians*Mathf.Rad2Deg);
	}
    private Vector4 GetWorldMousePosition()
    {
        Camera camera = Camera.main;
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        Debug.DrawLine(Vector3.zero, transform.position, Color.green);
        worldPos.z = 0;
        return worldPos;
    }
}
