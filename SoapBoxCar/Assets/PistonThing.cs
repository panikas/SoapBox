using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonThing : MonoBehaviour {

    public GameObject piston;
    [SerializeField]
    private float pistonMoveLength = 0.5f;
    private Vector3 endPos;
    private Vector3 startPos;
    private Vector3 restPos;
    [SerializeField]
    private float lerpTime = 1f;
    private float currentLerpTime;
	// Use this for initialization
	void Start () {
        startPos = piston.transform.localPosition;
        endPos = piston.transform.localPosition;
        restPos = piston.transform.localPosition;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            startPos = piston.transform.localPosition;
            endPos.Set(0, pistonMoveLength, 0);
            currentLerpTime = 0f;
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            startPos = piston.transform.localPosition;
            endPos = restPos;
            currentLerpTime = 0f;
        }
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime > lerpTime)
        {
            currentLerpTime = lerpTime;
        }
        
    }
    void FixedUpdate()
    {

        float perc = currentLerpTime / lerpTime;
        piston.transform.localPosition = Vector3.Lerp(startPos, endPos, perc);
    }
   

}
