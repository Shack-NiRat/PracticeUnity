using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    public Button button;


    private void Start()
    {
        button.onClick.AddListener(QuitApplication);
    }

    private void QuitApplication()
    {
        Application.Quit();
    }
}
