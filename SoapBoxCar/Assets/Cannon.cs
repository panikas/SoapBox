using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

    public float recoil, bulletSpeed;
    public Rigidbody rb;
    public ParticleSystem ps;
    public KeyCode key;
    public GameObject cannonball;
    public GameObject spawnPoint;

    void Start()
    {
    }

    void FixedUpdate()
    {
        
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(key))
        {
            GameObject cannonballInstance = Instantiate(cannonball, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
            cannonballInstance.GetComponent<Rigidbody>().AddForce(cannonballInstance.transform.forward * bulletSpeed, ForceMode.Impulse);

            ps.Play(true);
            rb.AddForceAtPosition(-transform.forward * recoil, transform.position, ForceMode.Impulse);
        }
    }

}
