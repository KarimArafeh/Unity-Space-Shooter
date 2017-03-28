using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletDamage : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll)
	{
		//Collided with a ship? Then destroy it.
		if(coll.gameObject.tag == "ship"){
			Destroy(coll.gameObject);
		}
		// Destroy Bullet in any case
		Destroy(gameObject);

	}

}
