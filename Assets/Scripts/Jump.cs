using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody reggiebody;
    
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //Vector3.up = (0, 1, 0)
            Vector3 forceVector = Vector3.up * jumpForce;
            reggiebody.AddForce(forceVector);

            print("Down");
        }
        else if (Input.GetButton("Jump"))
        {
            print("Hold");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            print("Up");
        }
    }
}
