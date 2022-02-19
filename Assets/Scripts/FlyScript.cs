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

//GameObject orginalGameObject= GameObject.FindWithTag("mainplane");
 //sc = GameObject.FindGameObjectsWithTag("main").GetComponent<scrip>();
//sc1 = GameObject.Find("righfoot").GetComponent<scrip1>();

 //GameObject child1 = GameObject.Find("Captury Plane/unknown(30004)/Capsule/rightfoot").gameObject;

// sc= ob.GetComponent<scrip>();
 //sc = child.GetComponent<scrip>();
 
 //sc1 = child1.GetComponent<scrip1>();
 
 
 
 audio = GetComponent<AudioSource>();
 audio.Play();
 
 
 
}
void Update()
{

 
 //sc1.tilecollider = false;
 if(move){
  
  
//calculate what the new Y position will be
float newY = Mathf.Sin(Time.time * speed) * height + pos.x;
//set the object's Y to the new calculated Y
transform.position = new Vector3( newY,transform.position.y, transform.position.z) ;
}
if(!move)
{
         //  Destroy (gameObject, 3);
         
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
 // sc = collision.gameObject.GetComponent<scrip>();
 // sc1 = collision.gameObject.GetComponent<scrip1>();
  //sc.tilecollider = true;
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
