using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketForce : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;
    public ParticleSystem ps;
    public KeyCode key;

    void Start()
    {
    }

    void FixedUpdate()
    {
        
        if (Input.GetKey(key)) {
            rb.AddForceAtPosition(transform.forward * thrust, transform.position, ForceMode.Force);
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
