using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyDamage : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll)
	{
		//Collided with a ship? Then destroy it.
		if(coll.gameObject.tag == "EnemyShip")
		Destroy(coll.gameObject);

		// Destroy Bullet in any case
		Destroy(gameObject);
	}
}
