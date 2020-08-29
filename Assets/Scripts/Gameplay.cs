using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
	private Character player;

	private void Start()
	{
		player = FindObjectOfType<Character>();
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
			PlayerMove(Vector3.forward);
		if (Input.GetKey(KeyCode.DownArrow))
			PlayerMove(Vector3.back);
		if (Input.GetKey(KeyCode.LeftArrow))
			PlayerMove(Vector3.left);
		if (Input.GetKey(KeyCode.RightArrow))
			PlayerMove(Vector3.right);
	}

	private void PlayerMove(Vector3 direction)
	{
		player.Move(direction);
	}
}
