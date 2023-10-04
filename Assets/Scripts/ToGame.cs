using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToGame : MonoBehaviour
{
    public Button button;


    private void Start()
    {
        button.onClick.AddListener(GoToGame);
    }

    private void GoToGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
