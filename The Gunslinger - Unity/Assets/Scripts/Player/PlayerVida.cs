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
			AñadirVida();
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

	public void QuitarVida()
	{
		Health -= 2;
	}

	public void AñadirVida()
	{
		Health += 1;
	}

	#endregion
}
