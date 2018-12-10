using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationsScript : MonoBehaviour {
    public float rotation = 5f;
    public Rigidbody body;
    private float x;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        x += Time.deltaTime * rotation;
        body.MoveRotation(Quaternion.Euler(x,0,0));        //transform.Rotate(v, Time.deltaTime * rotation);
	}
}
