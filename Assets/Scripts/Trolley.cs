using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trolley : MonoBehaviour
{
    [SerializeField] private List<GameObject> canTakePrefabs;

    public UnityEvent collectedObjectEvent;
    public UnityEvent notCollectedObjectEvent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       foreach(GameObject obj in canTakePrefabs)
            if(obj == collision.gameObject)
    }
}
