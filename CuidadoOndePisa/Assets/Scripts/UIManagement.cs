using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagement : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textLives;
    [SerializeField] TextMeshProUGUI textColect;

    public void UpdateStatus(int lives, int points)
    {
        textLives.text = lives.ToString();
        textColect.text = points.ToString();
    }

    public void UpdatePoints(int points)
    {
        textColect.text = points.ToString();
    }

    public void UpdateLives(int lives)
    {
        textLives.text = lives.ToString();
    }

}
