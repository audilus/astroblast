using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    //Ref to player
    public GameObject target;
    //Camera Follow speed
    public float followSpeed = 1f;

    // Use this for initialization
    void Start()
    {   
        if (target == null)
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPos = new Vector3(target.transform.position.x, 
                                     target.transform.position.y, 
                                     transform.position.z);
        Vector3 newWithCam = (newPos + Camera.main.ScreenToWorldPoint(Input.mousePosition)) / 2;
        //Debug.Log(newWithCam);
        this.transform.position = Vector3.Lerp(transform.position, 
                                               newWithCam, 
                                               followSpeed * Time.fixedDeltaTime);
    }
}
