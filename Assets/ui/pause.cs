using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pause : MonoBehaviour
{
    [SerializeField]
    public Canvas pausse;
    public void pauuse(InputAction.CallbackContext context)
    {
        Debug.Log("wirking");
       
        if (pausse != null)
        {
            hudmanager.addtoscreen(pausse);
        }
        else
        {
            hudmanager.removefromsceane(pausse);
        }
       

    }
}
