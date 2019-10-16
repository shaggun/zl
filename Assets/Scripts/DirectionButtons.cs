using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DirectionButtons : MonoBehaviour
{
    public static event Action<bool> OnUpDirection = delegate { };
    public static event Action<bool> OnDownDirection = delegate { };
    public static event Action<bool> OnLeftDirection = delegate { };
    public static event Action<bool> OnRightDirection = delegate { };

    public void UpRightBtnDown()
    {
        OnUpDirection(true);
        OnRightDirection(true);
    }

    public void UpRightBtnUp()
    {
        OnUpDirection(false);
        OnRightDirection(false);
    }

    public void UpLeftBtnDown()
    {
        OnUpDirection(true);
        OnLeftDirection(true);
    }

    public void UpLeftBtnUp()
    {
        OnUpDirection(false);
        OnLeftDirection(false);
    }

    public void DownRightBtnDown()
    {
        OnDownDirection(true);
        OnRightDirection(true);
    }

    public void DownRightBtnUp()
    {
        OnDownDirection(false);
        OnRightDirection(false);
    }

    public void DownLeftBtnDown()
    {
        OnDownDirection(true);
        OnLeftDirection(true);
    }

    public void DownLeftBtnUp()
    {
        OnDownDirection(false);
        OnLeftDirection(false);
    }
}
