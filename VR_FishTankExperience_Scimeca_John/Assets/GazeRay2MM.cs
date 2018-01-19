﻿using System.Collections;

using UnityEngine;

public class GazeRay2MM : MonoBehaviour {

    int InteractiblesLayerMask = 1 << 13;
    VRSlider2MainMenu gazedAtScript;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1000, InteractiblesLayerMask))
        {
            Debug.Log("Near Interactive");

            gazedAtScript = hit.transform.gameObject.GetComponent<VRSlider2MainMenu>();

            gazedAtScript.gazedAt = true;



            // gazedAt.HP = true;

            //  UIactionIcon.SetActive(true);

        }
        else
        {
            if (gazedAtScript != null)
            {
                gazedAtScript.gazedAt = false;
            }



        }
    }
}
