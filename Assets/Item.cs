using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log(other.gameObject.name + " が接触した");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " が離れた");
    }
}
