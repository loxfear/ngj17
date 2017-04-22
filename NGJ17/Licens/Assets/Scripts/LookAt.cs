using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt: MonoBehaviour
{
    // Use this for initialization
    public Transform target;


    // Update is called once per frame
    void Update()
    {
        Vector3 tempPos = new Vector3(target.position.x, 0, target.position.z); //this will only affect the y axis, you can shuffle the values around to make it only x or only z or a combination of any.
        transform.LookAt(tempPos);
    }
}