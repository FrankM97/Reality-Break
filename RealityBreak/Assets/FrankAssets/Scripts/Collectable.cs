using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Collectable : MonoBehaviour {
	public int count;
	public Text countText;
   
	
	

	public void Start() {
		count = 0;
		SetCountText();
		
	}

	private void OnTriggerEnter(Collider other) {
		if(other.tag == "Collectable") {
			Destroy(other.gameObject);
			count = count + 1;
			SetCountText();
			
		}
	}



	void SetCountText() {
		countText.text = "Collected: " + count.ToString();
		if (count == 5)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("Win");
        }
    }
}
	//Some bits of this code were from the Unity Tutorial Roll-A-Ball, mainly the countText code
	//The other bits came from Statement on Unity Answers
	//Some bits were modified slightly to fit my game.

