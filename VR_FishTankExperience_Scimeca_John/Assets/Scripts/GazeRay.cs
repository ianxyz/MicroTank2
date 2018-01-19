﻿using UnityEngine;
using System.Collections;

public class GazeRay : MonoBehaviour {

    int InteractiblesLayerMask = 1 << 13;
    GazeRayReciever gazedAtScript;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (gazedAtScript != null)
        {
            gazedAtScript.HitByRay = false;
        }

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1000, InteractiblesLayerMask))
        {
            Debug.Log("Near Interactive");

            gazedAtScript = hit.transform.gameObject.GetComponent<GazeRayReciever>();

            gazedAtScript.HitByRay = true;
            


           // gazedAt.HP = true;

          //  UIactionIcon.SetActive(true);

        }
        
    }
}
