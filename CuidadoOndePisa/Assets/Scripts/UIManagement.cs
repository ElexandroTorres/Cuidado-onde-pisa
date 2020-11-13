using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagement : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textLives;
    [SerializeField] TextMeshProUGUI textColect;

    //private static int livesCount = 3;
    //private static int colectCount = 0;
    // Start is called before the first frame update

    
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

    /*
    public void UpdateColectPoints(int points)
    {
        colectCount += points;
        showPoints();
    }

    public void LivesDown()
    {
        livesCount--;
        showPoints();
    }

    public int NumberOfLives()
    {
        return livesCount;
    }
    */
}
