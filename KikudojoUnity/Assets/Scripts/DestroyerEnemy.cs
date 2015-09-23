using UnityEngine;
using System.Collections;

public class DestroyerEnemy : MonoBehaviour {
	public AudioClip enemy_die;
	public AudioSource Explosion;

void OnTriggerEnter2D(Collider2D other)
	{

		if(other.tag == "Player")
	{
		Debug.Break ();
			return;
	}
		if (other.tag == "Enemy") 
		{
			Destroy (other.gameObject.transform.gameObject);
			Explosion.PlayOneShot (enemy_die, .5f);

		}
	
}
}
