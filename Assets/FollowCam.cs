using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

  


    // Start is called before the first frame update
    public Transform headCam;
 

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, headCam.position, Vector3.Magnitude(transform.position - headCam.position)*Time.deltaTime*5f);
    }
}
