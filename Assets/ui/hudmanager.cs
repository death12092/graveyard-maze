using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class hudmanager : MonoBehaviour
{
    [SerializeField]
    public Canvas mainmenu;
    private void Start()
    {
        addtoscreen(mainmenu);
    }
    public static Canvas addtoscreen(Canvas uiprefab)
    {
       if(uiprefab != null)
        {
            return Instantiate(uiprefab);
        }
        else
        {
            Debug.LogError("nope");
        }
        return null;
    }
    
    
    public static void removefromsceane(Canvas ui)
    {
        if (ui != null)
        {
            Destroy(ui.gameObject);
        }
        else
        {
            Debug.LogError("not a thing");
        }
    }
}
