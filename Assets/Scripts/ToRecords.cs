using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToRecords : MonoBehaviour
{
    public Button button;


    private void Start()
    {
        button.onClick.AddListener(GoToRecords);
    }

    private void GoToRecords()
    {
        SceneManager.LoadScene("Records", LoadSceneMode.Single);
    }
}
