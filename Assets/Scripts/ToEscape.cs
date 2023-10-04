using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ToEscape : MonoBehaviour
{
    public Button button;


    private void Start()
    {
        button.onClick.AddListener(GoToEscapeMenu);
    }

    private void GoToEscapeMenu()
    {
        SceneManager.LoadScene("Exit", LoadSceneMode.Single);
    }
}
