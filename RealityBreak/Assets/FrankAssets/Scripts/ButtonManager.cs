using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
	public void NewGameBtn(string newGameLevel) {
		SceneManager.LoadScene(newGameLevel);
	}

	public void StoryBtn(string storyLevel) {
		SceneManager.LoadScene(storyLevel);
	}

	public void MainMenuBtnStory(string mainMenuReturn) {
		SceneManager.LoadScene(mainMenuReturn);
	}

	public void CreditsBtn(string creditsBtn) {
		SceneManager.LoadScene(creditsBtn);
	}
	//Thank you SpeedTutor on YouTube for the tutorial on Title Screens!
}
