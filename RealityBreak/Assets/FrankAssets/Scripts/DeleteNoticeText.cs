using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DeleteNoticeText : MonoBehaviour {

	public float time = 5; 

	IEnumerator Start() {
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}
	//Thank you karl_jones on Unity Answers for this code, which hides the "Collect 5 Gold Spheres" Text!
}
