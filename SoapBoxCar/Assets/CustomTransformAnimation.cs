using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTransformAnimation : MonoBehaviour {
	// Use this for initialization
	void Start () {
    }
    public IEnumerator AnimatePosition(Vector3 origin, Vector3 target, float duration, GameObject obj, AnimationCurve curve)
    {
        float journey = 0f;
        
        while (journey <= duration)
        {
            journey += Time.deltaTime;
            float percent = Mathf.Clamp01(journey/duration);
            obj.transform.position = Vector3.LerpUnclamped(origin, target, curve.Evaluate(percent));
            yield return null;
        }
    }
    public IEnumerator AnimateLocalPosition(Vector3 origin, Vector3 target, float duration, GameObject obj, AnimationCurve curve)
    {
        float journey = 0f;

        while (journey <= duration)
        {
            journey += Time.deltaTime;
            float percent = Mathf.Clamp01(journey / duration);
            obj.transform.localPosition = Vector3.LerpUnclamped(origin, target, curve.Evaluate(percent));
            yield return null;
        }
    }
    public IEnumerator AnimateLocalScale(Vector3 origin, Vector3 target, float duration, GameObject obj, AnimationCurve curve)
    {
        float journey = 0f;

        while (journey <= duration)
        {
            journey += Time.deltaTime;
            float percent = Mathf.Clamp01(journey / duration);
            obj.transform.localScale = Vector3.LerpUnclamped(origin, target, curve.Evaluate(percent));
            yield return null;
        }
    }

    public IEnumerator AnimateRotation(Quaternion origin, Quaternion target, float duration, GameObject obj, AnimationCurve curve)
    {
        float journey = 0f;

        while (journey <= duration)
        {
            journey += Time.deltaTime;
            float percent = Mathf.Clamp01(journey / duration);
            print(obj.transform.position);
            obj.transform.rotation = Quaternion.LerpUnclamped(origin, target, curve.Evaluate(percent));
            yield return null;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
