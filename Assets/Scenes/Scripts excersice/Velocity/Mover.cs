using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] Vector3 velocity;

    Vector3 displacement;

    public void Update()
    {
        move();
    }
    public void move()
    {
        displacement = velocity * Time.deltaTime;
        transform.position = transform.position + displacement;
    }
}
