using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

interface IInteractable
{
    public void Interact(CharacterController _characterController);
}
public class Interact : MonoBehaviour
{
    public float InteractRange;
    public TextMeshProUGUI TextMeshPro;
    
    private CharacterController _characterController;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        Ray ray = new Ray(gameObject.transform.position, gameObject.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, InteractRange))
        {
            TextMeshPro.gameObject.SetActive(true);
            if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj) && Input.GetButtonDown("Action"))
            {
                interactObj.Interact(_characterController);
            }
        }
        else
        {
            TextMeshPro.gameObject.SetActive(false);
        }
    }
}
