using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPequeno : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void btnSalir()
	{
		Application.Quit ();
	}
	public void btnMenu ()
	{
		SceneManager.LoadScene (0);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
