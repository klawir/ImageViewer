using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupSize : MonoBehaviour
{
    public Transform celestialBody;
    public float howManyTimes;
    public bool less;
    public bool more;

    public void InitSize()
    {
        if (less)
            transform.localScale = celestialBody.localScale / howManyTimes;
        if (more)
            transform.localScale = celestialBody.localScale * howManyTimes;
    }
}
