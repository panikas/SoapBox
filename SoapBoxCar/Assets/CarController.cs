using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
    
    [SerializeField]
    private float carSpeed = 0.01f;
    [SerializeField]
    private float carAcceleration = 1.01f;
    [SerializeField]
    private float turnSpeed = 1.1f;

    private float xTransform = 0f, zTransform = 0f, yRotate = 0f, zSpeed = 0f, xSpeed = 0f;
    // Use this for initialization
    void Start () {
        print("Initializing CarController");

    }
	
	// Update is called once per frame
	void Update () {
        MoveCar();
	}
    void MoveCar()
    {
        transform.Translate(MoveVector());
        transform.Rotate(RotateDirection());
    }

    Vector3 MoveVector()
    {
        Vector3 move = new Vector3();
        zSpeed = Mathf.Clamp(zSpeed + TransformDirection().z * carAcceleration, -carSpeed, carSpeed);
        xSpeed = Mathf.Clamp(xSpeed + TransformDirection().x * carAcceleration, -carSpeed, carSpeed);
        zSpeed *= 0.95f;
        xSpeed *= 0.95f;
        move.Set(xSpeed, 0f, zSpeed);




        return move;
    }

    Vector3 TransformDirection()
    {
        
        Vector3 direction = new Vector3();
        float zDirection = 0f;
        float xDirection = 0f;
        float yRotation = 0f;

        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            zDirection = 1f;
        }
        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
        {
            zDirection = -1f;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.W))
        {
            zDirection = 0f;
        }
        if (Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.Q))
        {
            xDirection = 1f;
        }
        if (Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.E))
        {
            xDirection = -1f;
        }
        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E))
        {
            xDirection = 0f;
        }
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            yRotation = 1f;
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            yRotation = -1f;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
        {
            yRotation = 0f;
        }

        direction.Set(xDirection, yRotation, zDirection);
        return direction;
    }
    Vector3 RotateDirection()
    {
        Vector3 direction = new Vector3();
        yRotate = yRotate + TransformDirection().y * 0.1f;
        yRotate *= 0.95f;
        yRotate = Mathf.Clamp(yRotate, -turnSpeed, turnSpeed);
        direction.Set(0f, yRotate, 0f);

        return direction;
    }
}
