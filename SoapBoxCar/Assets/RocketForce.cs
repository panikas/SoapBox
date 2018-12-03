using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketForce : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;
    public ParticleSystem ps;
    public KeyCode key;
    public ForceMode forceMode;
    public bool forceAtPosition = true;

    void Start()
    {
    }

    void FixedUpdate()
    {
        
        if (Input.GetKey(key)) {
            if (forceAtPosition) { 
            rb.AddForceAtPosition(transform.forward * thrust, transform.position, forceMode);
            }
            else
            {
                rb.AddForce(transform.forward * thrust, forceMode);
            }
        }
        
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(key))
        {
            ps.gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(key))
        {
            ps.gameObject.SetActive(false);
        }
    }

}
