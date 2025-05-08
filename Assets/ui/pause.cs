using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pause : MonoBehaviour
{
    [SerializeField]
    public Canvas pausetospawn;
    private Canvas spawnedpause;
    public void pauuse(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            
            if (pausetospawn != null && spawnedpause == null)
            {
                spawnedpause = hudmanager.addtoscreen(pausetospawn);
                Time.timeScale = 0;
            }
            else
            {
                hudmanager.removefromsceane(spawnedpause);
                Time.timeScale = 1;
            }
        }
        
       

    }
}
