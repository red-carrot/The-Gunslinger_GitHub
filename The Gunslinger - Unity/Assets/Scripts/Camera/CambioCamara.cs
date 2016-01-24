using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MouseOrbitImproved))]
[RequireComponent(typeof(PointingCamera))]

public class CambioCamara : MonoBehaviour 
{
	#region Variables Publicas y Privadas

	public PlayerController pContr = null;
	public PointingCamera scrPC = null;
	public MouseOrbitImproved scrMOI = null;

	#endregion


	#region Funciones Start, Update...

	void Start()
	{
		pContr = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
		scrPC = GetComponent<PointingCamera>();
		scrMOI = GetComponent<MouseOrbitImproved>();
	}
	
	void Update() 
	{
		scrPC.enabled = pContr._aim;
		scrMOI.enabled = !pContr._aim;
		
		if(true == pContr._aim)
		{
			if(GetComponent<Camera>().fieldOfView > 30.0f)
				GetComponent<Camera>().fieldOfView --;
		}
		else
		{
			GetComponent<Camera>().fieldOfView = 90.0f;
		}
	}

	#endregion


	#region Colisiones

	#endregion
}
