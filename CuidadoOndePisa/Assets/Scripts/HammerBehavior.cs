using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerBehavior : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime * 2);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().AddForce(Vector3.right * 10, ForceMode.Impulse);
        }
    }

}
