using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {

    public delegate void TouchAction();
    public static event TouchAction OnLeft;
    public static event TouchAction OnRight;

    public bool left;
    public bool right;

    private void OnMouseDown()
    {
        if (OnLeft != null && left)
            OnLeft();
        if (OnRight != null && right)
            OnRight();
    }

}
