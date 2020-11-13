using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    
    private Vector3 distanceToPlayer;

    void Start()
    {
        distanceToPlayer = transform.position - Player.transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(0, Player.transform.position.y, Player.transform.position.z) + distanceToPlayer;
    }
}
