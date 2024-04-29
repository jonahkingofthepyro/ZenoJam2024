using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public Sprite openDoor;
    public Sprite closeDoor;
    public bool isOpen = false;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;
    private GameObject datoToGameObject;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
        if (isOpen)
        {
            boxCollider.enabled = false;
            spriteRenderer.sprite = openDoor;

        }
        if (!isOpen)
        {
            boxCollider.enabled = true;
            spriteRenderer.sprite = closeDoor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact(Component sender, object data)
    {
        if(data.GetType() == typeof(GameObject))
        {
            datoToGameObject = (GameObject)data;
        }
        
        
        
        if (datoToGameObject.name == this.gameObject.name)
        {
            
            toggleDoor();

        }

    }
    private void toggleDoor()
    {
        if (isOpen)
        {

            Debug.Log("close door");
            spriteRenderer.sprite = closeDoor;
             boxCollider.enabled = isOpen;
            isOpen = false;
           
        }
       
        else if (!isOpen)
        {
            boxCollider.enabled = isOpen;
            spriteRenderer.sprite = openDoor;
            isOpen = true;
        }
    }


}
