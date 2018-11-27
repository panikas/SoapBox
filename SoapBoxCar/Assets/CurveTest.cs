using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveTest : MonoBehaviour {
    [SerializeField]
    private GameObject obj;
    public float duration = 1f;
    [SerializeField]
    private AnimationCurve animC;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Vector3 vector = new Vector3(10,10,10);
            StartCoroutine(GetComponent<CustomTransformAnimation>().AnimatePosition(transform.position, vector, duration, obj, animC));
        }
	}
}
