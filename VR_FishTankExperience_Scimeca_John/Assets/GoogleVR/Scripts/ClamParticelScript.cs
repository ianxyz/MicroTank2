using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClamParticelScript : MonoBehaviour {



	public ParticleSystem clamParticle;
	public ParticleSystem clamParticleC2;
    public ParticleSystem clamParticleC3;
    public ParticleSystem clamParticleC4;
    public ParticleSystem clamParticleC5;
    public ParticleSystem clamParticleC6;
    public ParticleSystem clamParticleC7;
    public ParticleSystem clamParticleC8;
    public ParticleSystem clamParticleC9;

    // Use this for initialization
    void Start () {
		clamParticle = clamParticle.GetComponent<ParticleSystem> ();
		clamParticleC2 = clamParticleC2.GetComponent<ParticleSystem> ();
        clamParticleC3 = clamParticleC3.GetComponent<ParticleSystem>();
        clamParticleC4 = clamParticleC4.GetComponent<ParticleSystem>();
        clamParticleC5 = clamParticleC5.GetComponent<ParticleSystem>();
        clamParticleC6 = clamParticleC6.GetComponent<ParticleSystem>();
        clamParticleC7 = clamParticleC7.GetComponent<ParticleSystem>();
        clamParticleC8 = clamParticleC8.GetComponent<ParticleSystem>();
        clamParticleC9 = clamParticleC9.GetComponent<ParticleSystem>();
    }
	


	public void DigStart(){
		Debug.Log ("Clam is digging");
	
		clamParticle.Play ();

	}
	public void DigStartC2(){
		Debug.Log ("Clam2 is digging");

		clamParticleC2.Play ();

	}
    public void DigStartC3()
    {
        Debug.Log("Clam2 is digging");

        clamParticleC3.Play();

    }
    public void DigStartC4()
    {
        Debug.Log("Clam2 is digging");

        clamParticleC4.Play();

    }
    public void DigStartC5()
    {
        Debug.Log("Clam2 is digging");

        clamParticleC5.Play();

    }
    public void DigStartC6()
    {
        Debug.Log("Clam2 is digging");

        clamParticleC6.Play();

    }
    public void DigStartC7()
    {
        Debug.Log("Clam2 is digging");

        clamParticleC7.Play();

    }
    public void DigStartC8()
    {
        Debug.Log("Clam2 is digging");

        clamParticleC8.Play();

    }
    public void DigStartC9()
    {
        Debug.Log("Clam2 is digging");

        clamParticleC9.Play();

    }

}
