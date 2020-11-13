using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearGroundBehavior : MonoBehaviour
{
    [SerializeField] bool isDisappear = false;

    private Collider collider;

    private void Start() 
    { 
        collider = GetComponent<Collider>();
        if(isDisappear)
        {
            collider.isTrigger = true;
        }
    }

    public void Disappear() 
    { 
        isDisappear = true; 
    }
    
    public bool IsDisappear() 
    { 
        return isDisappear; 
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player") && isDisappear)
        {
            this.gameObject.SetActive(false);
        }
    }
}
