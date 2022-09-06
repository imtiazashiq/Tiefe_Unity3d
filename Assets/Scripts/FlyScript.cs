using UnityEngine;
using System.Collections;
 
public class FlyScript : MonoBehaviour
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
 //public GameObject ob;
    

Vector3 pos;
bool move= true;

private void Start()
{
pos = transform.position;
sc.tilecollider = true;
sc1.tilecollider = true;
audio = GetComponent<AudioSource>();
 audio.Play();
 
 
 
}
void Update()
{

 
 if(move){
  
 float newY = Mathf.Sin(Time.time * speed) * height + pos.x;
transform.position = new Vector3( newY,transform.position.y, transform.position.z) ;
}
if(!move)
{
         
         Invoke("Destroy", 3);
         audio.Stop();
}

}
void OnCollisionEnter(Collision collision) 
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
  Destroy(gameObject);
 }
}

public void Destroy()
{
 Destroy(gameObject);
 sc.tilecollider = false;
 sc1.tilecollider = false;
}
}
