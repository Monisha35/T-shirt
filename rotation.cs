using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

    public GameObject obj1;
   

    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    public void Rotasi()
    {
        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }
    void Update()
    {
        if (rotateStatus == true)
        {
            obj1.transform.Rotate(new Vector3(0f,1f,0f));
           

        }
    }
}
