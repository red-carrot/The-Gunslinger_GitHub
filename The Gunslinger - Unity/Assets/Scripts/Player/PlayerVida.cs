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
		if (coli.gameObject.tag == "Enemigo")
		{
			Health -= 2;
			print("T ago dano nen");
		}

		if (coli.gameObject.tag == "Vida")
		{
			Health += 1;
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
}
