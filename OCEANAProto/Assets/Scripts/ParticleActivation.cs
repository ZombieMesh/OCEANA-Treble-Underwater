using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivation : MonoBehaviour
{

    public GameObject brassParticles;
    public GameObject bassParticles;
    public GameObject fishParticles;
    public GameObject bubbleParticles;



    private bool brassOn = false;
    private bool bassOn = false;
    private bool fishOn = false;
    private bool bubbleOn = false;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown((KeyCode.V)) && brassOn == false)
        {
            brassParticles.SetActive(true);
            brassOn = true;
        }
        else if (Input.GetKeyDown((KeyCode.V)) && brassOn == true)
        {
            brassParticles.SetActive(false);
            brassOn = false;
        }

        if (Input.GetKeyDown((KeyCode.B)) && bassOn == false)
        {
            bassParticles.SetActive(true);
            bassOn = true;
        }
        else if (Input.GetKeyDown((KeyCode.B)) && bassOn == true)
        {
            bassParticles.SetActive(false);
            bassOn = false;
        }

        if (Input.GetKeyDown((KeyCode.N)) && fishOn == false)
        {
            fishParticles.SetActive(true);
            fishOn = true;
        }
        else if (Input.GetKeyDown((KeyCode.N)) && fishOn == true)
        {
            fishParticles.SetActive(false);
            fishOn = false;
        }

        if (Input.GetKeyDown((KeyCode.M)) && bubbleOn == false)
        {
            bubbleParticles.SetActive(true);
            bubbleOn = true;
        }
        else if (Input.GetKeyDown((KeyCode.M)) && bubbleOn == true)
        {
            bubbleParticles.SetActive(false);
            bubbleOn = false;
        }




    }
}
