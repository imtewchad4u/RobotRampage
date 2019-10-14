﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pickups;
    // Start is called before the first frame update
    void Start()
    {
        spawnPickup();
    }

    void spawnPickup()
    {
        GameObject pickup = Instantiate(pickups[Random.Range(0, pickups.Length)]);
        pickup.transform.position = transform.position;
        pickup.transform.parent = transform;
    }

    IEnumerator respawnPickup()
    {
        yield return new WaitForSeconds(20);
        spawnPickup();
    }

    public void PickupWasPickedUp()
    {
        StartCoroutine("respawnPickup");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
