using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour {
    public float hAxis; // private float
    public float vAxis; // private float
    [SerializeField] // Used to change the values of charSpeed quickly and easily. Since charSpeed is private, this is required.
    private float charSpeed;
	// Use this for initialization
	void Start () { 
		//put stuff in here if you want it to be initialized
	}

    // Update is called once per frame
    void Update() {
        hAxis = Input.GetAxisRaw("Horizontal"); //Gets raw input between -1 and 1 of input for the horizontal axis.
        vAxis = Input.GetAxisRaw("Vertical"); //Gets raw input between -1 and 1 of input for the vertical axis.
    }
    // Physics update called set amount of times per frame.
    void FixedUpdate()
    {
        inputMove(); // Calls inputMove() Function
    }
    public void inputMove() { // Function checks to see if player gives any input. If so, this function continuously moves the player until input is removed
       
        // Moves Character a certain speed. Uses Time.deltaTime to maintain consistency between varying framerates

        if (hAxis < 0 && vAxis == 0) // Checks for Raw Axis Input Left
        {
            transform.Translate(Vector2.left * charSpeed * hAxis * Time.fixedDeltaTime); 
        }
        if (vAxis < 0 && hAxis == 0) // Checks for Raw Axis Input Down
        {
            transform.Translate(Vector2.down * charSpeed * vAxis * Time.fixedDeltaTime);
        }
        if (hAxis > 0 && vAxis == 0) // Checks for Raw Axis Input Right
        {
            transform.Translate(Vector2.right * charSpeed * hAxis * Time.fixedDeltaTime);
        }
        if (vAxis > 0 && hAxis == 0) // Checks for Raw Axis Input Up
        {
            transform.Translate(Vector2.up * charSpeed * vAxis * Time.fixedDeltaTime);
        }

        // Divides by the square root of two to accurately move at the same speed

        if (hAxis < 0 && vAxis < 0) // Checks for Raw Axis Input Bottom left
        {
            transform.Translate((Vector2.left/Mathf.Sqrt(2)) * charSpeed * hAxis * Time.fixedDeltaTime);
            transform.Translate((Vector2.down/Mathf.Sqrt(2)) * charSpeed * vAxis * Time.fixedDeltaTime);
        }
        if (vAxis < 0 && hAxis > 0) // Checks for Raw Axis Input Bottom right
        {
            transform.Translate((Vector2.right / Mathf.Sqrt(2)) * charSpeed * hAxis * Time.fixedDeltaTime);
            transform.Translate((Vector2.down / Mathf.Sqrt(2)) * charSpeed * vAxis * Time.fixedDeltaTime);
        }
        if (hAxis > 0 && vAxis > 0) // Checks for Raw Axis Input Top right
        {
            transform.Translate((Vector2.right / Mathf.Sqrt(2)) * charSpeed * hAxis * Time.fixedDeltaTime);
            transform.Translate((Vector2.up / Mathf.Sqrt(2)) * charSpeed * vAxis * Time.fixedDeltaTime);
        }
        if (vAxis > 0 && hAxis < 0) // Checks for Raw Axis Input Top left
        {
            transform.Translate((Vector2.left / Mathf.Sqrt(2)) * charSpeed * hAxis * Time.fixedDeltaTime);
            transform.Translate((Vector2.up / Mathf.Sqrt(2)) * charSpeed * vAxis * Time.fixedDeltaTime);
        }
    }
}
