using UnityEngine;
using System.Collections;

public class Proyectil : MonoBehaviour 
{
	public float speed;

	public void SetSpeed (float newSpeed)
	{
		speed = newSpeed;
		Destroy(gameObject, 5f);
	}

	void FixedUpdate () 
	{
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}

	/*void OnCollisionEnter (Collision coli)
	{
		if (coli.gameObject)
		{
			Destroy(gameObject);

			Destruir Enemigo
			if (coli.gameObject.tag == "Enemigo")
			{
				GameObject enemy = GameObject.FindWithTag ("Enemigo");
				Destroy(enemy);
			}
		}
	}*/
}
