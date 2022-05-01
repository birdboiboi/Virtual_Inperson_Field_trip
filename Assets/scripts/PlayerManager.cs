using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int idx = 1;
    public bool isPlayer = true;
    //public Transform spawnLocation;

    public GameObject head;
    public GameObject body;
    public GameObject arSes;
    public GameObject arSesOrig;


    void OnAwake()
    {
        isPlayer = (idx == StartGame.idx);
        if (!isPlayer)
        {
            head.transform.SetParent(this.transform);
            body.transform.SetParent(this.transform);
            Destroy(arSesOrig);
            Destroy(arSes);
        }
        else
        {
            arSesOrig.SetActive(true);
            arSes.SetActive(true);
            head.transform.SetParent(arSesOrig.transform);
            body.transform.SetParent(arSes.transform);
        }

        Debug.Log(StartGame.idx);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
