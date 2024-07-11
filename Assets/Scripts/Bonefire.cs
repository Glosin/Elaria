using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bonefire : MonoBehaviour, IInteractable
{ 
    public CanvasController bonefireCanvas;
    
    public void Interact(CharacterController player)
    {
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
	    bonefireCanvas.OpenCanvas(playerMovement);
    }
}
