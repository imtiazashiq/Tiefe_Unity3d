using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifter : MonoBehaviour
{
public Transform currentposition;
public Transform target;
public float speed;

void Update()
{
    // Moves the object forward at two units per second.
   
}
       // transform.position = transform.position + new Vector3(0, 5f * m_Speed * Time.deltaTime, 0);
    void FixedUpdate(){
        Vector3 a= currentposition.position;
        Vector3 b= target.position;
        transform.position = Vector3.MoveTowards(a,b, speed* Time.deltaTime);
    }
}
