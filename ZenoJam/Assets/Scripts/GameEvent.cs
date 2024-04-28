using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent")]
public class GameEvents : ScriptableObject
{
    public List<Listener> listeners = new List<Listener>();
    public void Raise(Component sender, object data)
    {
        for (int i = 0; i < listeners.Count; i++)
        {
           listeners[i].OnEventRaised(sender,data);
        }

    }

    public void AddListener(Listener listener)
    {
        if (!listeners.Contains(listener))
        {
            listeners.Add(listener);

        }
    }
    public void RemoveListener(Listener listener)
     {
        if (listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }



     }









    }














