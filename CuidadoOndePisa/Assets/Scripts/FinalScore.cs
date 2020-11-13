using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textLives;
    [SerializeField] TextMeshProUGUI textColect;
    [SerializeField] TextMeshProUGUI finalScore;

    [SerializeField] GameObject gameManager;

    private int score = 0;
    
    void Start()
    {
        score = int.Parse(textLives.text) * int.Parse(textColect.text);
        finalScore.text = score.ToString();
    }

    void Update() {
        if(Input.GetKey(KeyCode.Space))
        {
            gameManager.GetComponent<GameManager>().NextLevel();
        }
    }

}
