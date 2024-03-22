using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoActivar : MonoBehaviour {

//	public Animation anim;
	//blic Animator animtr;
	// Use this for initialization
	public AudioSource asAvatar;
	void Start () {
		//animtr.Play("HerAnim");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void TargetPresente()
	{
		GetComponent<Animation> ().Play ();
		//animtr.speed=1;

		GetComponent<AudioSource> ().Play ();
	}
	void TargetNoPresente()
	{
		//animtr.speed=0;
		asAvatar.Pause ();

	}
}
