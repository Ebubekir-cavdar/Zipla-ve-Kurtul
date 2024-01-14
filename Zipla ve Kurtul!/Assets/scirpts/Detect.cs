using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    Turret turretScript;

    private void Awake()
    {
	turretScript = GameObject.Find("Turret").GetComponent<Turret>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
	if(collision.gameObject.CompareTag("player"))
	{
		turretScript.isClose = true;
		turretScript.Fire();
	}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("player"))
	{
		turretScript.isClose = false;
	}
    }
}
