using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(EnemigoMuerto))]

public class EnemigoControl : MonoBehaviour 
{
	#region Variables publicas y privadas
	
	//public float speed;
	public float DistanciaMirar;
	public float DistanciaSeguir;

	private GameObject objetivo;
	private NavMeshAgent NavSeguir;
	private Animator _animEnemigo;

	bool bFollow;
	bool death;

	public GameObject sInsulto;

	// Quitar vida
	PlayerVida pPv;

	#endregion


	#region Funciones Start y Update

	void Start()
	{
		NavSeguir = GetComponent<NavMeshAgent> ();
		objetivo = GameObject.FindWithTag ("Player");
		_animEnemigo = GetComponent<Animator> () as Animator;
		death = false;

		sInsulto.SetActive (false);

		// Vida
		pPv = GameObject.FindWithTag("Player").GetComponent<PlayerVida>();
	}

	void FixedUpdate()
	{
		_animEnemigo.SetBool ("follow", bFollow);
		_animEnemigo.SetBool ("death", death);

		bFollow = false;

		// Mirar al prota y seguirlo

		float fDistanciaPlayer;

		fDistanciaPlayer = Vector3.Distance (gameObject.transform.position, objetivo.transform.position);

		if (fDistanciaPlayer < DistanciaMirar) 
		{
			gameObject.transform.LookAt (objetivo.transform.position);
		}

		if (fDistanciaPlayer < DistanciaSeguir) 
		{
			NavSeguir.SetDestination (objetivo.transform.position);
			bFollow = true;
			sInsulto.SetActive(true);
		} else {
			sInsulto.SetActive(false);
		}
	}

	#endregion

	#region Colisiones

	void OnCollisionEnter(Collision coli)
	{
		if (coli.gameObject.tag == "bala") 
		{
			gameObject.GetComponent<EnemigoMuerto>().enabled = true;
		}
	}

	void OnTriggerStay (Collider coli)
	{
		if (coli.gameObject.tag == "Player")
		{
			pPv.QuitarVida(2);
		}
	}

	#endregion

}
