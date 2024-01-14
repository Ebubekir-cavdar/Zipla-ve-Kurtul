using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
   private Vector2 direction;
   private Vector2 target;
   
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("player");
	
	if(player != null)
	{

	target = player.transform.position;

	direction = target - (Vector2)transform.position;

	transform.right = -direction;

	}
    }
}
