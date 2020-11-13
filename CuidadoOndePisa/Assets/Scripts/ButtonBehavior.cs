using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    [SerializeField] GameObject[] grounds;

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player"))
        {
            foreach (var ground in grounds)
            {
                if(ground.GetComponent<DisappearGroundBehavior>().IsDisappear())
                {
                    ground.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                }
                else
                {
                    ground.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                }
            }
        }
    }

    private void OnCollisionExit(Collision other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            foreach (var ground in grounds)
            {
                ground.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
            }
        }
    }

}
