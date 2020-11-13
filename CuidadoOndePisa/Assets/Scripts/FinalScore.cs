using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textLives;
    [SerializeField] TextMeshProUGUI textColect;
    [SerializeField] TextMeshProUGUI finalScore;

    private int score = 0;
    
    void Start()
    {
        score = int.Parse(textLives.text) * int.Parse(textColect.text);
        finalScore.text = score.ToString();

        if(Input.GetKey(KeyCode.Space))
        {

        }
    }

}
