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

    // The event to trigger when the collider enters the trigger area
    public UnityEvent onTriggerEnterEvent;

    // Keeps track of whether the trigger has already activated
    private bool once = false;

    // Called when a collider enters the trigger area
    private void OnTriggerEnter(Collider other)
    {
        // If onlyTriggerOnce is true and the trigger has already activated, exit the function
        if(onlyTriggerOnce)
        {
            if (once) return;
        }

        // If the collider has the seekingTag, trigger the onTriggerEnterEvent
        if (other.CompareTag(seekingTag))
        {
            onTriggerEnterEvent.Invoke();
          
            // If destroyOnTrigger is true, destroy the game object after the specified time
            if (destroyOnTrigger)
            {
                Destroy(gameObject, timeToDestroy);
            }

            // If onlyTriggerOnce is true, set once to true to prevent the trigger from activating again
            if (onlyTriggerOnce)
            {
                once = true;
            }
        }
    }
}
