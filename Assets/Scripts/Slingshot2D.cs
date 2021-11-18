using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot2D : MonoBehaviour
{
    //The force that will be applied to the force when we release our mouse
    public float SlingshotForce;
    //The rigidbody on this object
    public Rigidbody2D reggiebody;

    //The start position of the dragging motion
    Vector3 startMousePos;
    //Keeps track of whenever you started clicking on the ball
    bool draggingBallZ = false;

    Vector3 mouseVector;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && draggingBallZ == true)
        {
            mouseVector = Input.mousePosition - startMousePos;
            reggiebody.AddForce(-mouseVector * SlingshotForce);
            draggingBallZ = false;
        }
    }

    private void OnMouseDown()
    {
        startMousePos = Input.mousePosition;
        draggingBallZ = true;
    }
}
