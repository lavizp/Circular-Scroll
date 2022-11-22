using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCameraCheck : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int index = transform.GetSiblingIndex();
        if (index == 2)
        {
            transform.localEulerAngles = new Vector3(0, 90, 0);
        }
/*        if (index == 1)
        {
            transform.localEulerAngles = new Vector3(0, 166, 0);
        }
        if (index == 2)
        {
            transform.localEulerAngles = new Vector3(0, -15, 0);
        }
        if (index == 3)
        {
            transform.localEulerAngles = new Vector3(0, -166, 0);
        }
        if (index == 4)
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }*/
    }
}
