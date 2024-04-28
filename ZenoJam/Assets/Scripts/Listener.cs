using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class  CustomGameEvent : UnityEvent<Component, object> { }


public class Listener : MonoBehaviour
{
    public CustomGameEvent reply;
    public GameEvents events;
 public void OnEventRaised(Component sender, object data)
    {
        reply.Invoke(sender, data);
    }
    /// Start is called before the first frame update
    private void OnEnable()
    {
        // Adds events to the list of listeners
        events.AddListener(this);

    }

    private void OnDisable()
    {
        events.RemoveListener(this);
    }
   
}
