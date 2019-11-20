using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseState : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>() != null)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
