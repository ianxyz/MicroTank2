using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuExit : MonoBehaviour {


    public GazeRayReciever myRayReciever;
    public GameObject rightController;
    private SteamVR_TrackedController device;

    public Renderer m_Renderer;
    public Material m_NormalMaterial;
    public Material m_OverMaterial;

    // Use this for initialization
    void Start()
    {
        m_Renderer.material = m_NormalMaterial;

        device = rightController.GetComponent<SteamVR_TrackedController>();
        device.TriggerClicked += Trigger;

        myRayReciever = GetComponent<GazeRayReciever>();
    }

    // Update is called once per frame
    void Update()
    {

        //put the gazed at material on
        if (myRayReciever.HitByRay == true)
        {
            m_Renderer.material = m_OverMaterial;
            Debug.Log("you looked at me");

        }

        //put the material back to normal
        if (myRayReciever.HitByRay == false)
        {
            m_Renderer.material = m_NormalMaterial;
            Debug.Log("you looked at me");

        }


    }

    //clicked the menu button, do what that menu button should do
    void Trigger(object sender, ClickedEventArgs e)
    {
        if (myRayReciever.HitByRay == true)
        {

            Debug.Log("you clicked me");

            Time.timeScale = 1;
            Application.Quit();
        }
    }


}
