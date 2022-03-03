using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    Vector3 acceleration;
    [SerializeField] Vector3 velocity;
    [SerializeField] public float xBorder, yBorder, mass, frontalArea, GravityConstant;
    [SerializeField] GameObject ExtraPlanet;
    [SerializeField] [Range(0, 1)] float damping, fricCoefic, dragCoefi;
    Gravity gravy;
    float velocityN;
    Vector3 displacement, befoColi, friction, hidra, fuerzaGrav,distance;
    float NormalF = 5;
    private void Start()
    {
        gravy = ExtraPlanet.GetComponent<Gravity>();
    }
    private void Update()
    {
        distance = ExtraPlanet.transform.position - transform.position;


        fuerzaGrav = ((GravityConstant * mass*gravy.mass)/(distance.magnitude*distance.magnitude))*distance.normalized;
           ApplyForce(fuerzaGrav);
            //ApplyForce(friction);
        

        move();
        //CheckCollisions();
        acceleration = Vector3.zero;
    }
    public void move()
    {
        velocity += acceleration * Time.deltaTime;
        displacement = velocity * Time.deltaTime;
        transform.position = transform.position + displacement;
        transform.position.Draw(Color.red);
        friction.Draw(Color.blue);
        hidra.Draw(Color.green);

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
            velocity.y = (velocity.y * -1) * damping;
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
    private void ApplyForce(Vector3 force)
    {
        acceleration += force / mass;
    }
}
