using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resume : MonoBehaviour
{
    public void hide()
    {
        hudmanager.removefromsceane(this.gameObject.GetComponent<Canvas>());
    }
}
