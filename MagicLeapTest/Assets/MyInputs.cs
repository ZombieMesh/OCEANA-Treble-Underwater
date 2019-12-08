using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;
using UnityEngine.SceneManagement;

public class MyInputs : MonoBehaviour
{

	private MLInputController _controller;
	private bool _enabled = false;
	private bool _bumper = false;

	// Start is called before the first frame update
	void Start()
    {
		MLInput.Start();
		MLInput.OnControllerButtonDown += OnButtonDown;
		MLInput.OnControllerButtonUp += OnButtonUp;
		_controller = MLInput.GetController(MLInput.Hand.Left);
	}


	void OnDestroy()
	{
		MLInput.OnControllerButtonDown -= OnButtonDown;
		MLInput.OnControllerButtonUp -= OnButtonUp;
		MLInput.Stop();
	}


	// Update is called once per frame
	void Update()
    {

		if (_bumper && _enabled)
		{
			SceneManager.LoadScene("ModelTest");
		}


		CheckControl();
	}



	void CheckControl()
	{
		if (_controller.TriggerValue > 0.2f && _enabled)
		{
			_bumper = false;

		}
		else if (_controller.Touch1PosAndForce.z > 0.0f && _enabled)
		{
			float X = _controller.Touch1PosAndForce.x;
			float Y = _controller.Touch1PosAndForce.y;
			
		}
	}



	void OnButtonDown(byte controller_id, MLInputControllerButton button)
	{
		if ((button == MLInputControllerButton.Bumper && _enabled))
		{
			_bumper = true;
		}
	}

	void OnButtonUp(byte controller_id, MLInputControllerButton button)
	{
		if (button == MLInputControllerButton.HomeTap)
		{

			_enabled = true;
		}
	}




}
