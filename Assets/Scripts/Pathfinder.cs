using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    public Waypoint[] path;

    private void Awake()
    {
        path = gameObject.GetComponentsInChildren<Waypoint>();
    }
}
