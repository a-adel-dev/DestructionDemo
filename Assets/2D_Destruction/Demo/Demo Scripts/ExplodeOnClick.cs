using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Explodable))]
public class ExplodeOnClick : MonoBehaviour {

	private Explodable _explodable;
	private WallSpawner _wallSpawner;

	void Start()
	{
		_explodable = GetComponent<Explodable>();
		_wallSpawner = FindObjectOfType<WallSpawner>();
	}
	void OnMouseDown()
	{
		_explodable.explode();
		ExplosionForce ef = FindObjectOfType<ExplosionForce>();
		ef.doExplosion(transform.position);
		_wallSpawner.isWallInScene = false;
	}
}
