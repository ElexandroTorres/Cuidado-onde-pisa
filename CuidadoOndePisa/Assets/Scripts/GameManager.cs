using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] UIManagement uIManagement;

    private static int livesCount = 3;
    private static int pointsCount = 0;
    private Scene currentsScene;

    private void Start() {
        currentsScene = SceneManager.GetActiveScene();
    }

    private void LateUpdate() {
        if(uIManagement != null)
            uIManagement.UpdateStatus(livesCount, pointsCount);
    }

    public void GameOver() 
    { 
        ScoreSreen();
    }

    public int Lives() { return livesCount; }

    public int Points() { return pointsCount; }

    public void Death()
    {
        livesCount--;
        uIManagement.UpdateStatus(livesCount, pointsCount);
        if(livesCount <= 0)
            GameOver();
    }

    public void AddPoints() { pointsCount += 10; }

    public void ResetPoints() { pointsCount = 0; }

    public void ResetLives() { livesCount = 3; }

    public void ResetStatus()
    {
        pointsCount = 0;
        livesCount = 3;
    }

    public void NextLevel()
    {
        if(currentsScene.name == "Fase1")
        {
            SceneManager.LoadScene("Fase2");
        }
        if(currentsScene.name == "Fase2")
        {
            SceneManager.LoadScene("ScoreScreen");
        }
        if(currentsScene.name == "Fase3")
        {
            SceneManager.LoadScene("ScoreScreen");
        }
        if(currentsScene.name == "ScoreScreen")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void ScoreSreen()
    {
        SceneManager.LoadScene("ScoreScreen");
    }

}
