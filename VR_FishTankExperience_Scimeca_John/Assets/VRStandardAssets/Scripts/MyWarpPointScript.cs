﻿using UnityEngine;
using VRStandardAssets.Utils;



public class MyWarpPointScript : MonoBehaviour
    {

    [SerializeField]
    private GameObject thisWarpPoint;

    public GameObject rightController;

    public delegate void WarpAction();
    public static event WarpAction OnWarp;

    private bool lookedAtMe = false;
    [SerializeField] private VRInteractiveItem m_InteractiveItem;


    private SteamVR_TrackedController device;
    private void Start()
    {
       // rightController = GameObject.FindWithTag("RightController");
        device = rightController.GetComponent<SteamVR_TrackedController>();
        device.TriggerClicked += Trigger;
    }



    private void OnEnable()
        {
            m_InteractiveItem.OnOver += HandleOver;
            m_InteractiveItem.OnOut += HandleOut;
           // m_InteractiveItem.OnClick += HandleClick;
      
        }

        private void OnDisable()
        {
            m_InteractiveItem.OnOver -= HandleOver;
            m_InteractiveItem.OnOut -= HandleOut;
           // m_InteractiveItem.OnClick -= HandleClick;
        }

        



        [SerializeField]
        private Renderer m_Renderer;

        [SerializeField]
        private Material m_NormalMaterial;
        [SerializeField]
        private Material m_OverMaterial;

        [SerializeField]
        private Transform UserPos;

        private GameObject userPosition;
        public EasyController easyControllerScript;

        private void Awake()
        {
            m_Renderer.material = m_NormalMaterial;
            userPosition = GameObject.FindWithTag("Player");
            easyControllerScript = rightController.GetComponent<EasyController>();
    }


        //Handle the Over event
        private void HandleOver()
        {
        
            Debug.Log("Show over state");
            m_Renderer.material = m_OverMaterial;
        lookedAtMe = true;

        }


        //Handle the Out event
        private void HandleOut()
        {
            Debug.Log("Show out state");
            m_Renderer.material = m_NormalMaterial;
        lookedAtMe = false;

        }


    //Handle the Click event
    void Trigger(object sender, ClickedEventArgs e)
    {
        if (lookedAtMe == true)
        {
            if (easyControllerScript.menuOpen == false)
            {
                Vector3 pos = transform.position;

                UserPos.position = pos;

                //start a camera fade
                if (OnWarp != null)
                {
                    OnWarp();
                }
            }
        }
    }



        


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Destroy(other.gameObject);
            Debug.Log("hello");

            //switches the layer of this warp point to the ignore raycast layer
            //the gaze is not able to affect this warp point when set to ignore raycast
            //effectively prevents the user from warping to the point he is currently at
            gameObject.layer = 2;

            //disable the renderer so the warp point is not visible
            m_Renderer.enabled = false;

        }


    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //Destroy(other.gameObject);
            Debug.Log("later");

            //switches the layer of this warp point to one that is seen by the raycaster
            //in this case it is the Default layer, but may be set to specific gaze layer for performance
            gameObject.layer = 0;

            //enable the renderer so the warp point can be seen again
            m_Renderer.enabled = true;

        }


    }




}

