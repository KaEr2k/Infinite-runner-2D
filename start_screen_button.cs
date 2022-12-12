using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    // build number of scene to start when start button is pressed
    public int gameStartScene;

public void StartGame() {
        SceneManager.LoadScene(gameStartScene);
    }
}