﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemy : MonoBehaviour {

	//The bullet prefab
	public GameObject bullet;

	//The firing Interval
	public float interval = 2;

	// Use this for initialization
	void Start () {
		//call fire every few seconds
		InvokeRepeating("Fire", interval, interval);
	}
	void Fire()
	{
		// Spawn the bullet
		GameObject g = (GameObject)Instantiate(bullet,transform.position,Quaternion.identity);

		//Ignore Bullet<-->Enemy Ship collision
		Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(),transform.parent.GetComponent<Collider2D>());
	}
}
