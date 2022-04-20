using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour {

    [SerializeField] GameObject sprite;
    [SerializeField] float angle;
    [SerializeField] [Range(0, 10)] float period;
    [SerializeField] [Range(0, 10)] float amplitud;

	
	// Update is called once per frame
	void Update ()
    {
        float factor = Time.time / period;
        float moveX = amplitud * Mathf.Sin(1*Mathf.PI * factor);
        sprite.transform.position = new Vector3(moveX, moveX, transform.position.z);
	}
}
