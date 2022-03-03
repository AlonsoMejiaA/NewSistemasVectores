using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover2 : MonoBehaviour
{

    Vector3 acceleration;
    [SerializeField] float xBorder, yBorder;
    [SerializeField] [Range(0, 1)] float damping;
    [SerializeField]GameObject ultraball;

    Vector3 displacement, befoColi,posIni;
     [SerializeField] Vector3 velocity;
  
    private void Update()
    {
        acceleration = ultraball.transform.position - transform.position;
        move();
        
    }
    public void move()
    {
        velocity += acceleration * Time.deltaTime;
        displacement = velocity * Time.deltaTime;
        transform.position = transform.position + displacement;
        

    }
    private void CheckCollisions()
    {
        if (transform.position.x >= xBorder || transform.position.x <= -xBorder)
        {
            velocity.x = (velocity.x * -1) * damping;
            //PELIGRO:Codigo Cuantico
            //transform.position = new Vector3(xBorder - transform.position.x, transform.position.y, transform.position.z);
        }
        else if (transform.position.y >= yBorder || transform.position.y <= -yBorder)
        {
            velocity.y = (velocity.y * -1);
            //PELIGRO:Codigo Cuantico;
            //transform.position = new Vector3( transform.position.x, yBorder- transform.position.y, transform.position.z);
        }
    }

}

