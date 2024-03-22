using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	//int indicadorEscena;
	// Use this for initialization
	void Start () {
		
	}
	public void btnMinerva()
	{
		SceneManager.LoadScene (1);
	}
	public void btnHermione()
	{
		SceneManager.LoadScene (2);
	}
	public void btnRon()
	{
		SceneManager.LoadScene (3);
	}
	public void btnSeverus()
	{
		SceneManager.LoadScene (4);
	}
	public void btnHarry()
	{
		SceneManager.LoadScene (5);
	}
	public void btnAlbus()
	{
		SceneManager.LoadScene (6);
	}
	public void btnSalir()
	{
		Application.Quit ();
	}
	// Update is called once per frame
	void Update () {
		

	}
}
