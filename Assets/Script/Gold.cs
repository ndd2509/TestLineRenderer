using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public int health = 100;

	public GameObject deathEffect;

	public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die ()
	{
		  GameObject clone = Instantiate(deathEffect, transform.position, Quaternion.identity);
  Destroy(clone,0.5f);
    Destroy(gameObject);
	}
}
