using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private float scoreValue;

    void Start()
    {
        scoreValue = PlayerPrefs.GetFloat("PlayerScore");

        scoreText.SetText(scoreValue.ToString());
    }


}
