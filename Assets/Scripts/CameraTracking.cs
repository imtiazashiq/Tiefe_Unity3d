using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{

    [SerializeField] private GameObject headPosition;
    [SerializeField] private float yOffset;
    [SerializeField] private float xOffset;
    [SerializeField] private float zOffset;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, headPosition.transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(headPosition.transform.position.x + xOffset, headPosition.transform.position.y + yOffset, headPosition.transform.position.z + zOffset);
    }
}
