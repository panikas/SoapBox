using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {
    [SerializeField]
    private float floatStrength = 0.5f;
    [SerializeField]
    private Rigidbody balloon;
    [SerializeField]
    private GameObject balloonGraphic;
    private Vector3 restScale;
    [SerializeField]
    private AnimationCurve scaleCurve;
    [SerializeField]
    private float animationDuration;
    private IEnumerator co;
    // Use this for initialization
    void Start () {
        restScale = balloonGraphic.transform.localScale;
        
        co = GetComponent<CustomTransformAnimation>().AnimateLocalScale(balloonGraphic.transform.localScale, restScale * 2, animationDuration, balloonGraphic, scaleCurve);
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StopCoroutine(co);
            co = GetComponent<CustomTransformAnimation>().AnimateLocalScale(balloonGraphic.transform.localScale, restScale * 2, animationDuration, balloonGraphic, scaleCurve);
            StartCoroutine(co);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            StopCoroutine(co);
            co = GetComponent<CustomTransformAnimation>().AnimateLocalScale(balloonGraphic.transform.localScale, restScale, animationDuration, balloonGraphic, scaleCurve);
            StartCoroutine(co);
        }
    }
    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetKey(KeyCode.Alpha1)) { 
            balloon.AddForce(Vector3.up * floatStrength);
        }
    }
}
