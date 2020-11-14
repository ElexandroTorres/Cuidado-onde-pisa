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

    private GameManager _gameManager;
    private int score = 0;
    
    void Start()
    {
        _gameManager = gameManager.GetComponent<GameManager>();
        score = _gameManager.Lives() * _gameManager.Points();
        textLives.text = _gameManager.Lives().ToString();
        textColect.text = _gameManager.Points().ToString();
        finalScore.text = score.ToString();
    }

    void Update() {
        if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Return))
        {
            _gameManager.NextLevel();
        }
    }

}
