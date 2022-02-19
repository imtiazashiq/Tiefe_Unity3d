using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript2 : MonoBehaviour
{
    //adjust this to change speed
[SerializeField]
float speed = 5f;
//adjust this to change how high it goes
[SerializeField]
float height = 1f;
// public float lifetime=500f;
 
 public scrip sc;
 public scrip1 sc1;
 private AudioSource audio;

Vector3 pos;
bool move= true;

private void Start()
{
pos = transform.position;
audio = GetComponent<AudioSource>();
audio.Play();
sc.tilecollider = true;
sc1.tilecollider = true;
}
void Update()
{
 if(move){
//calculate what the new Y position will be
float newY = Mathf.Sin(Time.time * speed) * height + pos.z;
//set the object's Y to the new calculated Y
transform.position = new Vector3( transform.position.x, transform.position.y, newY) ;
}

 
 if(!move)
{
           //Destroy (gameObject, 3);
           Invoke("Destroy", 3);
           audio.Stop();

}
}
void OnCollisionStay(Collision collision) 
 {
         if(collision.gameObject.tag == "main")  // or if(gameObject.CompareTag("YourWallTag"))
         {
                     Debug.Log("WE HIT AN OBSTACLE");
                    move= false;
                    sc = collision.gameObject.GetComponent<scrip>();
                    sc1 = collision.gameObject.GetComponent<scrip1>();
                    
          
        }
 }

void OnCollisionExit(Collision collision) 
{
 if(collision.gameObject.tag == "main")  // or if(gameObject.CompareTag("YourWallTag"))
 {
  Debug.Log("WE HIT AN OBSTACLE");
  move= false;
  sc = collision.gameObject.GetComponent<scrip>();
  sc1 = collision.gameObject.GetComponent<scrip1>();
  sc.tilecollider = true;
  //sc1.tilecollider = true;
  Destroy(gameObject);


 }
}

public void Destroy()
{
 Destroy(gameObject);
 Debug.Log("dessssssssss");
 
 sc.tilecollider = false;
 sc1.tilecollider = false;
 
 
 //sc1.tilecollider = false;
}
 
}
