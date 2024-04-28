using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Example : MonoBehaviour
{
    private object whatInfoToSend = new object();
       

    // to broadcast an event ina a event
    [Header("Events")]
    public GameEvents nameOfEvent;
    public void OnEnable()
    {
        nameOfEvent.Raise(this, whatInfoToSend);
    }
    // when need update the event information
    


        
    // to listen to an event
    // need to add a listener to a srcipt
}
