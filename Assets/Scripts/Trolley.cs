using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trolley : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> canTakePrefabs;

    public UnityEvent collectedObjectEvent;
    public UnityEvent notCollectedObjectEvent;
    public UnityEvent getDamageEvent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (SpriteRenderer obj in canTakePrefabs)
            if (obj.sprite == collision.gameObject.GetComponent<SpriteRenderer>().sprite)
            {
                collectedObjectEvent?.Invoke();
                break;
            }

        if (collision.gameObject.GetComponent<Bomb>())
            getDamageEvent?.Invoke();
    }
}
