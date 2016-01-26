using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(SylviaMuerto))]
[RequireComponent(typeof(SylviaVida))]

public class SylviaControl : MonoBehaviour 
{
	#region Variables

	// Huir

	NavMeshAgent navHuir;
	GameObject objetivo;
	GameObject _prota;

	public float DistanciaMirar = 50.0f;
	public float DistanciaHuir = 100000.0f;
	public float DistanciaGritar = 15.0f;

	// Animaciones
	Animator _anim;
	bool bHuir;
	bool bGritar;

	// Quitar vida
	
	PlayerVida PV;

	#endregion


	#region Funciones Start y Update

	void Start()
	{
		// Huir
		navHuir = gameObject.GetComponent<NavMeshAgent>();
		_prota = GameObject.FindWithTag ("Player");
		objetivo = GameObject.Find ("ObjetivoSylvia");

		bHuir = false;

		// Animaciones

		_anim = GetComponent<Animator>();

		// Quitar vida
		PV = GameObject.FindWithTag ("Player").GetComponent<PlayerVida> ();
	}

	void Update()
	{
		// Definir las variables de la animacion

		_anim.SetBool("huir", bHuir);
		_anim.SetBool("gritar", bGritar);

		// Huir
		float fDistanciaObjetivo;
		float fDistanciaProta;

		fDistanciaObjetivo = Vector3.Distance(gameObject.transform.position, objetivo.transform.position);
		fDistanciaProta = Vector3.Distance(gameObject.transform.position, _prota.transform.position);


		if (fDistanciaObjetivo < DistanciaHuir)
		{
			navHuir.SetDestination (objetivo.transform.position);
			bHuir = true;
			print("a k no m pillaaaAsSs ¡ ¡");

			if (fDistanciaProta < DistanciaGritar)
			{
				bGritar = true;
				gameObject.transform.LookAt (_prota.transform.position);
				navHuir.SetDestination (gameObject.transform.position);
			}
			else
			{
				bGritar = false;
			}
		}
		else
		{
			bHuir = false;
		}
	}

	#endregion


	#region Colisiones

	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.tag == "Player") 
		{
			PV.QuitarVida(3);
		}
	}

	#endregion
}
