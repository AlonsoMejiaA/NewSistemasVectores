using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{

    [SerializeField] Vector3 acceleration;
    [SerializeField] float xBorder, yBorder;
    [SerializeField] [Range(0,1)] float damping;
 

    Vector3 displacement,velocity,befoColi;

    private void Update()
    {
        
        move();
        CheckCollisions();
    }
    public void move()
    {
        velocity += acceleration * Time.deltaTime;
        displacement = velocity * Time.deltaTime;
        transform.position = transform.position + displacement;
        transform.position.Draw(Color.red);
        
    }
    private void CheckCollisions()
    {
        if (transform.position.x >= xBorder ||transform.position.x <= -xBorder )
        {
            velocity.x = (velocity.x * -1)-damping;
            //PELIGRO:Codigo Cuantico
            //transform.position = new Vector3(xBorder - transform.position.x, transform.position.y, transform.position.z);
        }
        else if (transform.position.y >= yBorder || transform.position.y <= -yBorder)
        {
            velocity.y = (velocity.y * -1)-damping;
            //PELIGRO:Codigo Cuantico
            //transform.position = new Vector3( transform.position.x, yBorder- transform.position.y, transform.position.z);
            
        }
        if (transform.position.x > xBorder)
        {
            transform.position = new Vector3(xBorder, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xBorder)
        {
            transform.position = new Vector3(-xBorder, transform.position.y, transform.position.z);
        }
        if (transform.position.y > yBorder)
        {
            transform.position = new Vector3(transform.position.x, yBorder, transform.position.z);
        }
        if (transform.position.y < -yBorder)
        {
            transform.position = new Vector3(transform.position.x, -yBorder, transform.position.z);
        }
    }
    }



