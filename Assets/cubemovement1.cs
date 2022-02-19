using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemovement1 : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float height = 1f;

    private Vector3 pos;

    private bool move = true;
  
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            float newY = Mathf.Sin(Time.time * speed) * height + pos.z;
            transform.position = new Vector3(transform.position.x, transform.position.y, newY);
        }

        if (!move)
        {
            Destroy(gameObject, 3);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player") {
            Debug.Log("txxxxxx");
            move = false;
        }
    }
}
