using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagement : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textLives;
    [SerializeField] TextMeshProUGUI textColect;

    private static int livesCount = 3;
    private static int colectCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        showPoints();
    }

    // Update is called once per frame
    void Update()
    {
        showPoints();
    }

    private void showPoints()
    {
        textLives.text = livesCount.ToString();
        textColect.text = colectCount.ToString();
    }

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
}
