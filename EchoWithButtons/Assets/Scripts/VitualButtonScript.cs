using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VitualButtonScript : MonoBehaviour
{
    ParticleSystem[] effects;
    AudioSource audioSource;
    VirtualButtonBehaviour vrb;

    private GetModel getModel;

    // Start is called before the first frame update
    void Start()
    {
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterOnButtonPressed(onButtonPressed);
        vrb.RegisterOnButtonReleased(onButtonReleased);

        effects = GetComponentsInChildren<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();

        getModel = GetComponent<GetModel>();
    }

    public void onButtonPressed(VirtualButtonBehaviour bv)
    {
        effects[Random.Range(0, effects.Length)].Play();
        audioSource.Play();
        Debug.Log("button pressed");
    }

    public void onButtonReleased(VirtualButtonBehaviour bv)
    {

    }


    // Update is called once per frame
    void Update()
    {
    }
}
