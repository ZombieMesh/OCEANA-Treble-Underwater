using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleActivation : MonoBehaviour
{
	[System.Serializable]
	public class BubbleStruct
	{
		public GameObject BubbleParticle;
		public float BPStartTime;
		public float BPInterval;
		public float BPDuration;

		public BubbleStruct(GameObject bubbleParticle, float bPStartTime, float bPInterval, float bPDuration)
		{
			BubbleParticle = bubbleParticle;
			BPStartTime = bPStartTime;
			BPInterval = bPInterval;
			BPDuration = bPDuration;
		}
	}

	//"Bubble" Particles Holders


	
	public GameObject bpPartOne;
	public GameObject bPPartTwo;
	public GameObject bpPartThree;
	public GameObject bPPartFour;
	public GameObject bpPartFive;
	

	public static GameObject bubbleParticleOne;
	public static GameObject bubbleParticleTwo;
	public static GameObject bubbleParticleThree;
	public static GameObject bubbleParticleFour;
	public static GameObject bubbleParticleFive;




	public BubbleStruct bubbleSetOne = new BubbleStruct(bubbleParticleOne, 0f, 5f, 10f);
	public BubbleStruct bubbleSetTwo = new BubbleStruct(bubbleParticleTwo, 0f, 15f, 10f);
	public BubbleStruct bubbleSetThree = new BubbleStruct(bubbleParticleThree, 0f, 25f, 10f);
	public BubbleStruct bubbleSetFour = new BubbleStruct(bubbleParticleFour, 0f, 35f, 10f);
	public BubbleStruct bubbleSetFive = new BubbleStruct(bubbleParticleFive, 0f, 45f, 10f);

	/*
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
	*/


	// Start is called before the first frame update
	void Start()
    {
		/*
		bubbleParticleOne = bPPartOne;
		bubbleParticleTwo = bPPartTwo;
		bubbleParticleThree = bPPartThree;
		bubbleParticleFour = bPPartFour;
		bubbleParticleFive = bPPartFive;
		*/

		


		bubbleSetOne.BPStartTime = Time.time;
		bubbleSetTwo.BPStartTime = Time.time;
		bubbleSetThree.BPStartTime = Time.time;
		bubbleSetFour.BPStartTime = Time.time;
		bubbleSetFive.BPStartTime = Time.time;


	}

    // Update is called once per frame
    void Update()
    {
        
		//Particle One
		if (Time.time > bubbleSetOne.BPStartTime + bubbleSetOne.BPInterval)
		{
			bubbleSetOne.BubbleParticle.GetComponent<ParticleSystem>().Play();

			if (Time.time > bubbleSetOne.BPStartTime + bubbleSetOne.BPInterval + bubbleSetOne.BPDuration)
			{
				bubbleSetOne.BubbleParticle.GetComponent<ParticleSystem>().Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
				bubbleSetOne.BPStartTime = Time.time;
			}
		}


		//Particle Two
		if (Time.time > bubbleSetTwo.BPStartTime + bubbleSetTwo.BPInterval)
		{
			bubbleSetTwo.BubbleParticle.GetComponent<ParticleSystem>().Play();

			if (Time.time > bubbleSetTwo.BPStartTime + bubbleSetTwo.BPInterval + bubbleSetTwo.BPDuration)
			{
				bubbleSetTwo.BubbleParticle.GetComponent<ParticleSystem>().Stop(true, ParticleSystemStopBehavior.StopEmitting);
				bubbleSetTwo.BPStartTime = Time.time;
			}
		}






	}
}
