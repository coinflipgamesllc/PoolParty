using UnityEngine;
using System.Collections;

public class PrefabBehaviour : MonoBehaviour, PooledEntity
{
	public string PrefabText = "This is the initial value";

	public void ResetEntity ()
	{
		this.PrefabText = "This is the reset value as of " + Time.realtimeSinceStartup;
	}
}
