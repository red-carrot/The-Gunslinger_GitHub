using UnityEngine;
using System.Collections;

public class SylviaMuerto : MonoBehaviour 
{
	Animator _anim;
	NavMeshAgent _agent;

	void Start ()
	{
		_agent = GetComponent<NavMeshAgent>();
		_anim = GetComponent<Animator>();

		_agent.enabled = false;
		_anim.enabled = false;
	}
}
