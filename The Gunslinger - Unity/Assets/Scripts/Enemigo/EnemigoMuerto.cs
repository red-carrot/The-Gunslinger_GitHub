﻿using UnityEngine;
using System.Collections;

public class EnemigoMuerto : MonoBehaviour 
{
	#region Variables declaradas

	EnemigoControl eC;
	NavMeshAgent agente;
	PlayerVida PV;
	public GameObject sMuerte;

	#endregion



	#region Funciones Start, Update y demas

	void Start()
	{
		eC=GetComponent<EnemigoControl>();
		eC.enabled = false;

		PV = GameObject.FindWithTag("Player").GetComponent<PlayerVida>();

		agente = GetComponent<NavMeshAgent>();
		agente.enabled=false;

		sMuerte.SetActive (true);
	}

	#endregion


	#region Colisiones

	void OnTriggerStay(Collider coli)
	{
		if (coli.gameObject.tag == "Player")
		{
			PV.Health +=2;
		}
	}

	#endregion


}