using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool useEvents;

    [SerializeField]
    public string promptMessage;

    public virtual string OnLook()
    {
        return promptMessage;
    }

    public void BaseInteract()
    {
        if (useEvents)
        {
            InteractionEvent ie = GetComponent<InteractionEvent>();
            if (ie != null)
                ie.OnInteract.Invoke();
            else
                Debug.LogWarning("useEvents ticked but no InteractionEvent on " + name, this);
        }

        Interact();
    }

    protected virtual void Interact()
    {
    }
}
