using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickmover : MonoBehaviour
    {

        Vector3 acceleration;
        [SerializeField] float xBorder, yBorder, mass, gravity,frontalArea;

        [SerializeField] [Range(0, 1)] float damping, fricCoefic,dragCoefi;

        float velocityN;
        Vector3 displacement, velocity, befoColi, friction, hidra;
        float NormalF = 5;
        private void Update()
        {

            hidra = -(1F / 2F) * (velocity.magnitude * velocity.magnitude) * frontalArea * dragCoefi * velocity.normalized;
            friction = -1 * fricCoefic * NormalF * velocity.normalized;
            ApplyForce(new Vector3(0, gravity, 0));
            if (transform.position.y <= 0)
            {
                ApplyForce(hidra);
                //ApplyForce(friction);
            }

            move();
            CheckCollisions();
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


