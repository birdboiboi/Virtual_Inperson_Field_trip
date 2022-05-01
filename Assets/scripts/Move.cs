using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody theRB;

    public float forwardAccel = 8f, reverseAccel = 4f, maxSpeed = 50f, turnstrength = 180;

    public float speedInput, turnInput;
    // Start is called before the first frame update
    void Start()
    {
        theRB = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        speedInput = 0f;
        if (Input.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("Vertical") * forwardAccel * 1000f;
            transform.Translate(.05f * transform.right);

        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            speedInput = Input.GetAxis("Vertical") * reverseAccel * 1000f;
            transform.Translate(-.05f * transform.right);

        }

        turnInput = Input.GetAxis("Horizontal");


        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnstrength * Time.deltaTime * Input.GetAxis("Vertical"), 0f));
        transform.position = theRB.transform.position;

    }
    private void FixedUpdate()
    {

        if (Mathf.Abs(speedInput) > 0)
        {
            theRB.AddForce(transform.forward * forwardAccel * Time.deltaTime);
        }
    }


}