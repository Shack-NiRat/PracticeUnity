using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToMenu : MonoBehaviour
{
    public Button button;


    private void Start()
    {
        button.onClick.AddListener(GoToMenu);
    }

    private void GoToMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
