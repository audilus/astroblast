using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleRotate : MonoBehaviour {

    public float rotZ = 2;
    public float rotX = 2;

    public float zMult = 1.2f;
    public float xMult = 1.0f;

    public float totalTime;

	// Use this for initialization
	void Start () {
        Vector3 t = transform.localScale;
        //This does not work. Not sure why.
        transform.localScale = new Vector3(Mathf.Lerp(t.x * 100, t.x, 1),
                                          Mathf.Lerp(t.y * 100, t.y, 1),
                                          Mathf.Lerp(t.x * 100, t.y, 1));		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        totalTime += Time.fixedDeltaTime * 1.2f;
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        transform.position = new Vector3(x,
                                         y += (0.01f * Mathf.Sin(totalTime)),
                                         z);

        float rotZ = transform.eulerAngles.z;
        float rotX = transform.eulerAngles.x;
        transform.eulerAngles = new Vector3(rotX += (0.1f * Mathf.Cos(totalTime)),
                                            transform.eulerAngles.y,
                                            rotZ += (0.2f * Mathf.Cos(totalTime)));
	}
}
