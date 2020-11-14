using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformBehavior : MonoBehaviour
{
    [SerializeField] bool isGoing = true;
    [SerializeField] float startingPosition;
    [SerializeField] float returnPosition;
    [SerializeField] [Range(1f, 5f)] float plataformSpeed = 1.5f;
    [SerializeField] string plataformMovement;

    private Vector3 plataformDirection;
   
    void Start() 
    {
        // Plataforma se movementa de lado.
        if(plataformMovement == "Side")
        {
            plataformDirection = new Vector3(1, 0, 0);
        }    
        // Plataforma se move de frente, indo e voltando.
        else if(plataformMovement == "Front")
        {
            plataformDirection = new Vector3(0, 0, 1);
        }
        // Plataforma sobe e desce.
        else if(plataformMovement == "Up")
        {
            plataformDirection = new Vector3(0, 1, 0);
        }  
    }
    
    void Update()
    {
        var plataformMoves = PlataformMoves(plataformMovement);
        if(isGoing) 
        {
            transform.Translate(plataformDirection * Time.deltaTime * plataformSpeed);
            if(plataformMoves >= returnPosition)
            {
                isGoing = false;
            }
        }
        else
        {
            transform.Translate(plataformDirection * (-1) * Time.deltaTime * plataformSpeed);
            if(plataformMoves <= startingPosition)
            {
                isGoing = true;
            }
        }
    }

    private float PlataformMoves(string moveType)
    {
        if(moveType == "Side") return transform.position.x;
        else if(moveType == "Up") return transform.position.y;
        else return transform.position.z; //Front.
    }

    //Auxiliar na visualização do caminho das plataformas moveis.
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        if(plataformMovement == "Side")
        {
            Gizmos.DrawLine(new Vector3(startingPosition, transform.position.y, transform.position.z), new Vector3(returnPosition, transform.position.y, transform.position.z));
        }    
        
        if(plataformMovement == "Front")
        {
            Gizmos.DrawLine(new Vector3(transform.position.x, transform.position.y, startingPosition), new Vector3(transform.position.x, transform.position.y, returnPosition));
        }
        
        if(plataformMovement == "Up")
        {
            Gizmos.DrawLine(new Vector3(transform.position.x, startingPosition, transform.position.z), new Vector3(transform.position.x, returnPosition, transform.position.z));
        }
    }
}
