using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraversePath : MonoBehaviour
{
    public float speed;
    private int waypointIndex = 0;
    public Pathfinder path;

    private void Awake()
    {
        transform.position = path.path[waypointIndex].transform.position;
    }

    private void Update()
    {
        Traverse();
    }

    private void Traverse()
    {
        if (waypointIndex < path.path.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                path.path[waypointIndex].transform.position, speed * Time.deltaTime);

            if (transform.position == path.path[waypointIndex].transform.position)
            {
                waypointIndex++;
            }
        }
    }
}
