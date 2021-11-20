using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class DialogeTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent OnTriggerEnter = new UnityEvent();
    [SerializeField] private UnityEvent OnTriggerExit = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnTriggerEnter.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnTriggerExit.Invoke();
        }
    }
}
