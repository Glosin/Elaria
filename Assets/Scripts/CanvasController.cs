using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CanvasController : MonoBehaviour
{
    public void OpenCanvas(PlayerMovement _playerMovement)
    {
        gameObject.SetActive(true);
        _playerMovement.canMove = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CloseCanvas(PlayerMovement _playerMovement)
    {
        gameObject.SetActive(false);
        _playerMovement.canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void HideMenu(GameObject HideMenu)
    {
        HideMenu.SetActive(false);
    }
    public void ShowMenu(GameObject ShowMenu)
    {
        ShowMenu.SetActive(true);
    }

    [MenuItem("Tools/Attach OpenCanvas Script to All Canvases")]
    public static void AttachScript()
    {
        Canvas[] canvases = Resources.FindObjectsOfTypeAll<Canvas>();

        foreach (Canvas canvas in canvases)
        {
            if (canvas.gameObject.GetComponent<CanvasController>() == null)
            {
                canvas.gameObject.AddComponent<CanvasController>();
            }
        }
        Debug.Log("OpenCanvas script attached to all canvases.");
    }
}
