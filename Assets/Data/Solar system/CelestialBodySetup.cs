using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialBodySetup : MonoBehaviour
{
    public SetupSize[] setupSize;
	void Start ()
    {
        foreach(SetupSize setup in setupSize)
        {
            setup.InitSize();
        }
    }
}
