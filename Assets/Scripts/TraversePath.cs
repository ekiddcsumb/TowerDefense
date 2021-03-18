using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraversePath : MonoBehaviour
{
    public float speed;
    private int waypointIndex = 0;
    public Pathfinder path;

    private void Start()
    {
        transform.position = path.path[waypointIndex].transform.position;
    }
}
