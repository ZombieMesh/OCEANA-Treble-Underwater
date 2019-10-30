using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleActivation : MonoBehaviour
{
	//[System.Serializable]
	[SerializeField]
	public struct BubbleStruct
	{
		public GameObject BubbleParticle;
		public float BPStartTime;
		public float BPInterval;
		public float BPDuration;


		public BubbleStruct(GameObject bubbleParticle, float bPStartTime, float bPInterval, float bPDuration)
		{
			this.BubbleParticle = bubbleParticle;
			this.BPStartTime = bPStartTime;
			this.BPInterval = bPInterval;
			this.BPDuration = bPDuration;
		}

	}

	//BubbleStruct BubbleFive = new BubbleStruct();



	//"Bubble" Particles Holders
	public GameObject bubbleParticleOneT;
	public GameObject bubbleParticleTwoT;
	public GameObject bubbleParticleThree;
	public GameObject bubbleParticleFour;
	public GameObject bubbleParticleFive;

	//Timer Check Variables
	public float BPOneStartTimeT;
	public float BPTwoStartTimeT;
	public float BPThreeStartTime;
	public float BPFourStartTime;
	public float BPFiveStartTime;

	//Intervals At Which Particles Start/Stop
	public float BPOneIntervalT;
	public float BPTwoIntervalT;
	public float BPThreeInterval;
	public float BPFourInterval;
	public float BPFiveInterval;

	//How Long Particles Play
	public float BPOneDurationT;
	public float BPTwoDurationT;
	public float BPThreeDuration;
	public float BPFourDuraiton;
	public float BPFiveDuration;



	public BubbleStruct BubbleFive = new BubbleStruct(/*bubbleParticleFive, BPFiveStartTime, BPFiveInterval, BPDurationFive*/);


	// Start is called before the first frame update
	void Start()
    {

		//Start Timers
		BPOneStartTimeT = Time.time;
		BPTwoStartTimeT = Time.time;
		BPThreeStartTime = Time.time;
		BPFourStartTime = Time.time;
		BPFiveStartTime = Time.time;





	}

    // Update is called once per frame
    void Update()
    {
        
		if (Time.time > BPOneStartTimeT + BPOneIntervalT)
		{
			bubbleParticleOneT.GetComponent<ParticleSystem>().Play();

			//Reset Timer
			BPOneStartTimeT = Time.time;
		}






    }
}
