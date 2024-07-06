using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    void Start()
    {
        speed +=0.003f * Time.time;
        if(speed > maxSpeed)
        {
            speed = maxSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        Vector2 temp = transform.position;
        temp.x-= speed * Time.deltaTime;
        transform.position =temp;
    }
}
