using CoinFlipGames.PoolParty;
using System.Collections;
using UnityEngine;

public class GameObjectSpawner : MonoBehaviour
{
	public GameObject prefab;
	public uint preloadAmount = 200;

	void Start ()
	{
		PoolParty.Preload (prefab, (int)preloadAmount);
	}

	public void SpawnPrefab (int number = 1)
	{
		for (int i = 0; i < number; i++) {
			GameObject entity = PoolParty.Insantiate (this.prefab, Random.insideUnitSphere * 5, Quaternion.identity);
			PoolParty.Destroy (entity, 5f);
		}
	}
}
