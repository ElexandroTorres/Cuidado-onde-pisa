using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] Button start;
    [SerializeField] Button exit;

    void Start () {
		start.onClick.AddListener(startGame);
        exit.onClick.AddListener(exitGame);
	}

	void exitGame()
    {
		Application.Quit();
	}

    void startGame()
    {
        SceneManager.LoadScene("Fase1");
    }

    
}
