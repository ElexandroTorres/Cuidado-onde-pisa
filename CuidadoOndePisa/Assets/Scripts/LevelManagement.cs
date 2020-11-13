using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagement : MonoBehaviour
{

    private Scene scene;

    private void Start() {
        scene = SceneManager.GetActiveScene();
    }


    public void NextLevel()
    {
        if(scene.name == "Fase1")
        {
            SceneManager.LoadScene("Fase2");
        }
        if(scene.name == "Fase2")
        {
            SceneManager.LoadScene("ScoreScreen");
        }

    }

    private void Update() {
        if(scene.name == "ScoreScreen")
        {
            if(Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("MainMenu");
            }           
        }
    }
}
