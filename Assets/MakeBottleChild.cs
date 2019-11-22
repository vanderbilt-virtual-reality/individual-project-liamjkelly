using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBottleChild : MonoBehaviour
{
    GameObject grabbed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grabbed = gameObject.GetComponent<OVRGrabber>().grabbedObject;
        if (grabbed != null)
        {
            grabbed.transform.parent = gameObject.transform;
        }
    }
}
