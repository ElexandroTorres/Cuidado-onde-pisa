using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameObject levelManagement;


    private void OnCollisionEnter(Collision other) {
        levelManagement.GetComponent<LevelManagement>().NextLevel();
    }


}
