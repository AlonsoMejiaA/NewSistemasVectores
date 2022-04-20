using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinDrawer : MonoBehaviour {

    [SerializeField] GameObject Object;
    [SerializeField]int samples = 5;
    [SerializeField] [Range(0, 1)] float separation;
    [SerializeField] [Range(0, 20)] float height;
    [SerializeField] [Range(0, 100)] int extra;
	void Start ()
    {
        for (int i = 0; i < samples; i++)
        {
            var child = Instantiate(Object, transform);
          
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        int i = 0;
        foreach (Transform child in transform)
        {
            float x = i * separation;
            child.localPosition = new Vector3(x, Mathf.Sin(x+ Time.time)*height + Mathf.Sin(extra*x)*height, 0);
            i++;
        }
	}
}
