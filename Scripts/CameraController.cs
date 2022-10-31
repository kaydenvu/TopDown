using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // target is set to the transformation of player i.e. the camera follows 
    public float smoothing;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);

        if (transform.position != target.position) // if the camera position isn't the same as the desired one 
        {
            Vector3 targetPosition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x); // bounding camera to certain x
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y); // same but y

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing); // lerp makes the camera follow in a delay smooth
        }
    }
}
