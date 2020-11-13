using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{

    [SerializeField] Vector3 spawnPosition;
    [SerializeField] GameObject gameManager;

    //[SerializeField] GameObject uiManagement;

    private GameManager _gameManager;
    //private UIManagement _uiManagement;
    private Rigidbody rb;
    private Transform tempParent;
    private bool canJump = false;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tempParent = transform.parent;
        _gameManager = gameManager.GetComponent<GameManager>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * 5 * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * 5 * Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);

        if(transform.position.y < -5.5f)
        {
            Death();
        }
    }

    private void FixedUpdate() {
        if((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Z)) && canJump)
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            canJump = false;
        }    
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
            _gameManager.AddPoints();
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Floor")
        {
            canJump = true;
        }
        else if(other.gameObject.tag == "MovingFloor")
        {
            canJump = true;
            transform.parent = other.transform;
        }
    }

    private void OnCollisionExit(Collision other) {
        if(other.gameObject.tag == "MovingFloor")
        {
            transform.parent = tempParent;
        }
    }

    public void Death()
    {
        _gameManager.Death();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero; 
        transform.position = spawnPosition;
    }
}
