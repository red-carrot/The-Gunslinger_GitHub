using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerVida : MonoBehaviour 
{
	public Slider HealthBar;
	public float Health;

	void Start ()
	{
		Health = 100;
	}

	void OnTriggerStay (Collider coli)
	{
		if (coli.gameObject.tag == "Vida")
		{
			AñadirVida(1);
		}

		if (Health > 100)
		{
			Health = 100;
		}

		if (Health < 0)
		{
			Application.LoadLevel("99_testing");
		}
	}

	void Update ()
	{
		//Debug.Log (Health);
		if (HealthBar.name == "Slider")
		{
			HealthBar.value = Health;
		}
	}

	#region Funciones para añadir o quitar vida

	public void QuitarVida(int pX)
	{
		Health -= pX;
		print("Rolando has " + Health + " of vida");
	}

	public void AñadirVida(int pV)
	{
		Health += pV;
		print("Rolando has " + Health + " of vida");
	}

	#endregion
}
