using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int idx;
    public bool isPlayer = true;
    public Transform spawnLocation;

    public GameObject head;
    public GameObject body;
    public GameObject arSes;
    public GameObject arSesOrig;


    void Start()
    {

        if (!isPlayer)
        {
            head.transform.SetParent(this.transform);
            body.transform.SetParent(this.transform);
            Destroy(arSesOrig);
            Destroy(arSes);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
