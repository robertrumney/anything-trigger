using UnityEngine;
using UnityEngine.Events;

public class AnythingTrigger : MonoBehaviour
{
    // The tag that the collider must have to activate the trigger
    public string seekingTag;

    // Whether the game object should be destroyed when the trigger activates
    public bool destroyOnTrigger;

    // How long to wait before destroying the game object
    public float timeToDestroy;

    // Whether the trigger should only activate once
    public bool onlyTriggerOnce;

    // Events to trigger for each type of trigger event
    public UnityEvent onTriggerEnterEvent;
    public UnityEvent onTriggerExitEvent;
    public UnityEvent onTriggerStayEvent;

    // Keeps track of whether the trigger has already activated
    private bool triggered = false;

    // Called when a collider enters the trigger area
    private void OnTriggerEnter(Collider other)
    {
        // If onlyTriggerOnce is true and the trigger has already activated, exit the function
        if (onlyTriggerOnce && triggered) return;

        // If the collider has the seekingTag, trigger the onTriggerEnterEvent
        if (other.CompareTag(seekingTag))
        {
            onTriggerEnterEvent.Invoke();

            // If destroyOnTrigger is true, destroy the game object after the specified time
            if (destroyOnTrigger)
            {
                Destroy(gameObject, timeToDestroy);
            }

            // Mark the trigger as having fired at least once
            triggered = true;
        }
    }

    // Called when a collider exits the trigger area
    private void OnTriggerExit(Collider other)
    {
        // If onlyTriggerOnce is true and the trigger has already activated, exit the function
        if (onlyTriggerOnce && triggered) return;

        // If the collider has the seekingTag, trigger the onTriggerExitEvent
        if (other.CompareTag(seekingTag))
        {
            onTriggerExitEvent.Invoke();

            // If destroyOnTrigger is true, destroy the game object after the specified time
            if (destroyOnTrigger)
            {
                Destroy(gameObject, timeToDestroy);
            }

            // Mark the trigger as having fired at least once
            triggered = true;
        }
    }

    // Called when a collider stays within the trigger area
    private void OnTriggerStay(Collider other)
    {
        // If onlyTriggerOnce is true and the trigger has already activated, exit the function
        if (onlyTriggerOnce && triggered) return;

        // If the collider has the seekingTag, trigger the onTriggerStayEvent
        if (other.CompareTag(seekingTag))
        {
            onTriggerStayEvent.Invoke();

            // If destroyOnTrigger is true, destroy the game object after the specified time
            if (destroyOnTrigger)
            {
                Destroy(gameObject, timeToDestroy);
            }

            // Mark the trigger as having fired at least once
            triggered = true;
        }
    }
}
