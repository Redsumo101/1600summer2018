using UnityEngine;

public class Interactable : MonoBehaviour
{
//this defines how close the player needs to get to interact with an item or an enemy
    public float radius = 3f;
    public Transform interactionTransform;
    bool isFocus;
    Transform player;
    bool hasInteracted = false ;

    public virtual void Interact()
    {
        //this method is meant to be overridden
    }
    
    private void Update()
    { 
        //checks if it is being focused and if it is with the radius to intaract
        
        //this checks our distance so it can interact only if it hasnt interacted already
        
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }
    private void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}
