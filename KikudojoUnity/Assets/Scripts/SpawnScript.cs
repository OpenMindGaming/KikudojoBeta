using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
   // public float spawnMin = 10f;
//	public float spawnMax = f;

	// Use this for initialization
	void Start () 
	{
		Spawn();
	}
	
	void Spawn()
	{
		Instantiate(obj[Random.Range (0, obj.GetLength(0))], new Vector3 (transform.position.x + 50, 1, -2) , Quaternion.identity);
		Invoke ("Spawn", 8f);
	}
}
