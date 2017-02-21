using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Script that handles the game over scene
public class GameOver : MonoBehaviour
{
    private void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 60;

        if(GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2), (1 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Retry?"))
        {
            SceneManager.LoadSceneAsync("workingscene", LoadSceneMode.Single);
        }

        if(GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Back to Menu"))
        {
            SceneManager.LoadSceneAsync("MainMenu", LoadSceneMode.Single);
        }
    }
}
