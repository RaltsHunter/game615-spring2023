using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // At the top of a component you can create variables that can be referenced
    // throughout the entire component. When you write "public" infront of the
    // variable declaration it makes it so you can edit the value of the variable
    // from the Unity inspector.
    public float speed = 0.001f;
    public float launchForce = 1000;

    float rotateSpeed = 0.1f;

    // This variable will hold a reference to the rigid body component. You give
    // variable its value by dragging and dropping the component into the
    // inspector inside of Unity.
    public Rigidbody rb;

    float lastRotateDirectionSwitchTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 

        // Check to see if the Spacebar was just pressed. If so, tell the rigidbody
        // component to launch forward at a given speed (launchForce).
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.useGravity = true;
            rb.AddForce(gameObject.transform.forward * launchForce);
        }

        
    }

}
