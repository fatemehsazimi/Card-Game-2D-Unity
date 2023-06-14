using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tooltip : MonoBehaviour
{
    public string message;
    private void OnMouseEnter(){
        ToolTipManager._instance.setandshowtooltip(message);
    }
    private void OnMouseExit(){
        ToolTipManager._instance.hidetooltip();
    }
}
