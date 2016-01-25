using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MouseOrbitImproved))]
[RequireComponent(typeof(PointingCamera))]

public class CambioCamara : MonoBehaviour 
{
	#region Variables Publicas y Privadas

	PlayerController pContr = null;
	PointingCamera scrPC = null;
	MouseOrbitImproved scrMOI = null;
	MouseLook mLook = null;

	public GameObject PuntoMira;


	#endregion


	#region Funciones Start, Update...

	void Start()
	{
		pContr = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
		scrPC = GetComponent<PointingCamera>();
		scrMOI = GetComponent<MouseOrbitImproved>();
		mLook = GameObject.FindWithTag("Player").GetComponent<MouseLook>();
	}
	
	void Update() 
	{
		scrPC.enabled = pContr._aim;
		scrMOI.enabled = !pContr._aim;

		PuntoMira.SetActive(pContr._aim);
		mLook.enabled = pContr._aim;
		
		if(true == pContr._aim)
		{
			if(GetComponent<Camera>().fieldOfView > 20.0f)
				GetComponent<Camera>().fieldOfView --;
		}
		else
		{
			GetComponent<Camera>().fieldOfView = 70.0f;
		}
	}

	#endregion
}
