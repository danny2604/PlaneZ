using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryCam : MonoBehaviour {

    public Transform plane;
	void Update ()
    {
        transform.LookAt(plane);
	}
}
