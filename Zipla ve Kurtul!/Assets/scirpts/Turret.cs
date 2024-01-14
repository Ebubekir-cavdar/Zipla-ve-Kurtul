using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private Transform bulletPos;
    
    [SerializeField] GameObject gunLight;

    public bool isClose;

    [SerializeField] private float fireRate;

    private float nextfire = 0;
    
    private void Update()
    {
        GunLight();
    }
    
    void GunLight()
    {
    	if(isClose)
	{
		gunLight.GetComponent<SpriteRenderer>().color = Color.red;
	}
	else
	{
		gunLight.GetComponent<SpriteRenderer>().color = Color.green;
	}
    }

    public void Fire()
    {
	if (Time.time > nextfire)
	{
		nextfire = Time.time + 1 / fireRate;
		CreateBullet();
	}
    }

    private void CreateBullet()
    {
	
	
		GameObject bullet = BulletPool.instance.GetObjectFromPool();
		
		if(bullet != null)
		{
		bullet.transform.position = bulletPos.position;
		bullet.transform.rotation = bulletPos.rotation;
		bullet.SetActive(true);
		}
	
    }
}
