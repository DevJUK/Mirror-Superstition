using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMirrors : MonoBehaviour
{
	public GameObject MirrorPrefab;
	public int Limit;
	public int NumberInScene;


	private void Start()
	{
		NumberInScene = FindObjectsOfType<MirrorScrpt>().Length;
	}

	private void Update()
	{

		NumberInScene = FindObjectsOfType<MirrorScrpt>().Length;

		if (NumberInScene != Limit)
		{
			Vector3 RandomPos = new Vector3(Random.Range(-25, 25), 0, Random.Range(-25, 25));
			Vector3 RandomRot = new Vector3(0, Random.Range(0, 360), 0);
			Instantiate(MirrorPrefab, RandomPos, Quaternion.Euler(RandomRot));
		}
	}
}
