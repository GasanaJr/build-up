using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public void PlayGame() {
		SceneManager.LoadScene ("AssignmentOneScene");
	}
    public void OnApplicationQuit()
    {
        Application.Quit();

    }
}
