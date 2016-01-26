using UnityEngine;
using System.Collections;

public class SylviaVida : MonoBehaviour 
{
	public float Health;
	SylviaControl sC;
	SylviaMuerto sM;
	bool bMuerte;

	void Start ()
	{
		Health = 50;
		sC = GetComponent<SylviaControl> ();
		sM = GetComponent<SylviaMuerto> ();
		bMuerte = false;
	}

	void Update ()
	{
		sC.enabled = !bMuerte;
		sM.enabled = bMuerte;

		if (Health < 0) 
		{
			bMuerte = true;
		}
	}

	void OnCollisionEnter (Collision coli)
	{
		if (coli.gameObject.tag == "bala") 
		{
			Daño();
		}
	}

	void Daño ()
	{
		Health -= 150;
		Debug.Log (Health);
	}
}
