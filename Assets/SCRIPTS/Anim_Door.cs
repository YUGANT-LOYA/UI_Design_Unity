using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Door : MonoBehaviour
{
	private Animator door_anim;
	void Start()
	{
		door_anim = this.transform.parent.GetComponent<Animator>();
		gameObject.tag = "Door";
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			door_anim.SetBool("DoorOpening", true);
		}
		else
		{
			door_anim.SetBool("DoorOpening", false);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			door_anim.SetBool("DoorOpening", false);
		}
	}

	void Update()
    {
	    /*if (GameObject.FindGameObjectWithTag("Player") == null)
	    {
		    door_anim.SetBool("DoorOpening", false);
	    }*/
    }
}
