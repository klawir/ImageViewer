using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialBody : MonoBehaviour
{
    public float rotate;

	void Start ()
    {
		
	}

	void Update ()
    {
        transform.RotateAround(Vector3.down, rotate*Time.deltaTime);
	}
}
