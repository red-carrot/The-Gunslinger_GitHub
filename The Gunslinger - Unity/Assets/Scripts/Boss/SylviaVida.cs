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
		Health = 1000;
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

		if (Health > 2000)
		{
			Health = 2000;
		}
	}

	void OnCollisionEnter (Collision coli)
	{
		if (coli.gameObject.tag == "bala") 
		{
			Daño(150);
		}

		if (coli.gameObject.tag == "Enemigo")
		{
			Vida(200);
		}
	}

	#region Funciones de vida

	public void Daño (int pX)
	{
		Health -= pX;
		print("Sylvia has " + Health + " of vida");
	}

	public void Vida (int pV)
	{
		Health += pV;
		print("Sylvia has " + Health + " of vida");
	}

	#endregion

}
