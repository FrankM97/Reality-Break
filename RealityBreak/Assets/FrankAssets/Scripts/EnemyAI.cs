using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
	public Transform Player;
	public int MoveSpeed = 100;
	int MaxDist = 5;
	int MinDist = 2;




	void Start() {

	}

	void Update() {
		transform.LookAt(Player);

		if (Vector3.Distance(transform.position, Player.position) >= MinDist) {

			transform.position += transform.forward * MoveSpeed * Time.deltaTime;



			if (Vector3.Distance(transform.position, Player.position) <= MaxDist) {
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
				SceneManager.LoadScene("Death");
			}
			//Thank you Dee Va on Unity Answers for the Enemy AI!
		}
	}
}
