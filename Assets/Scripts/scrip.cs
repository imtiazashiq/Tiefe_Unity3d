using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class scrip : MonoBehaviour
{
 [SerializeField]
public bool planecollider= true;
 [SerializeField]
public bool tilecollider= true;
public GameObject ob;
//public FlyScript flyScript;
    public GameObject ob1;
    public Camera m_MainCamera;
    public Camera m_Cameratwo;
   // public GameObject ob3;
    private void Start()
{
planecollider= true;
tilecollider= true;
//m_MainCamera = Camera.main; 
//m_MainCamera.enabled = true;
//m_Cameratwo.enabled = false;

}
void Update()
{
 
lift();

}
/*    void OnTriggerEnter(Collider collision) 
 {
     
         if(collision.gameObject.tag == "plane")  // or if(gameObject.CompareTag("YourWallTag"))
         {
             if(planecollider==true){
                     Debug.Log("collid with plane");
             }
}
 
 
if(collision.gameObject.tag == "cube")  // or if(gameObject.CompareTag("YourWallTag"))
         {
            if(tilecollider==true){
                     Debug.Log("collid with plane");
             }
}
}

void OnTriggerExit(Collider collision){
    if(collision.gameObject.tag == "cube")  // or if(gameObject.CompareTag("YourWallTag"))
         {
              if(tilecollider){
           tilecollider=false;
           Debug.Log("collider off");
             }
         }
} */

  private  void OnCollisionEnter(Collision collision) 
 {
     
      if(collision.gameObject.tag == "plane")  // or if(gameObject.CompareTag("YourWallTag"))
        {
            
                   Debug.Log("collid with plane");
                   planecollider= true;
                   
                     
}              
      else  if(collision.gameObject.tag == "cube")  // or if(gameObject.CompareTag("YourWallTag"))
                 {
            
                     Debug.Log("collid with cube"); 
                     tilecollider= true;
                    
                     
              }
      else if(collision.gameObject.tag== "manfall"){
          Debug.Log("falling");
         // m_Cameratwo.enabled = true;
         // m_MainCamera.enabled = false;
         // m_MainCamera.gameObject.SetActive(false);
        // m_Cameratwo.gameObject.SetActive(true);
          ob1.SetActive(true);
         // ob3.SetActive(false);


      }
      }
  /*     void OnCollisionStay(Collision collision) 
      {
     
       //  if(collision.gameObject.tag == "plane")  // or if(gameObject.CompareTag("YourWallTag"))
        //  {
            
        //      Debug.Log("collid with plane");
         //     planecollider= true;
                   
                     
        //  }                 
           if(collision.gameObject.tag == "cube")  // or if(gameObject.CompareTag("YourWallTag"))
          {
            
              Debug.Log("stay stay stay stay stay");
              tilecollider= true;
                    
                     
          }

                    */
        
 private void OnCollisionExit(Collision col) 
 {
     
        if(col.gameObject.tag == "plane")  // or if(gameObject.CompareTag("YourWallTag"))
         {
                
                     planecollider= false;
                     Debug.Log("collidder exit");
                    
             } 
           if(col.gameObject.tag == "cube")  // or if(gameObject.CompareTag("YourWallTag"))
         {
                
                     tilecollider= false;
                     Debug.Log("drop from cube");
                     
                }
 }                

   void lift()
   {
       if(tilecollider==false && planecollider== true)
       {
           
           Debug.Log("lifting");
           ob.GetComponent<lifter>().enabled = true;
       }
   }
        
 }
