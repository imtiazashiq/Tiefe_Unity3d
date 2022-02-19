using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartgame : MonoBehaviour
{
    private GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag == "restart")
            Application.LoadLevel(0);
          // GameObject.Find("Plane").active = false;
        Debug.Log("restart restart");
    }
}

