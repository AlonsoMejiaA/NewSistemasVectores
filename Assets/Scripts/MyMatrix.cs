using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMatrix : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private Transform obsject;
    [SerializeField] float rotationZ;
    [SerializeField] Vector3 scale =Vector3.one;

	
	// Update is called once per frame
	void Update ()
    {
        obsject.position = new Vector3(4f, 4f, 0);
       var myMatrix =  Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, rotationZ), scale);
        var newPos = myMatrix.MultiplyVector(obsject.position);
        obsject.position = newPos;

	}
}
