﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

            if (playerScript != null)
            {
                playerScript.CollectCollectible();
            }
            Destroy(this.gameObject);
        }
    }
}
