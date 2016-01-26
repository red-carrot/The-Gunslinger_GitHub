using UnityEngine;
using System.Collections;

public class MovieTexture : MonoBehaviour 
{
	((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
}