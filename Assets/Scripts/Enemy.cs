using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 10f;
    private int coinAmount = 5;
    public Purse purse;

    public float distance;
    public LayerMask layerMask;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo, distance, layerMask))
            {
                if (hitInfo.collider.name == "Enemy")
                {
                    health--;
                    Debug.Log(health);
                }
            }
            
            if (health <= 0)
            {
                Destroy(hitInfo.transform.gameObject);
                purse.AddCoin(coinAmount);
            }
        }
    }
}
