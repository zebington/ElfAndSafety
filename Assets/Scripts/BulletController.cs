﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
	[SerializeField] private float _speed;
	
	private void Start()
	{
		GetComponent<Rigidbody2D>().velocity = transform.rotation * new Vector3(0, _speed);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		HandleHit(other);
	}

	public virtual void HandleHit(Collider2D other)
	{
		Destroy(gameObject);
	}
}
