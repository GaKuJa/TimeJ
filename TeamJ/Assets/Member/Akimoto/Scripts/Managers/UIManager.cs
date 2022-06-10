using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public enum HintButtonMode {
    normal,
    see,
    touch,
    shake,
}
public class UIManager : MonoBehaviour
{
    public static  UIManager              Instance { get => _instance; }
    private static UIManager            _instance;
    private        HintButtonMode         hintMode;

    [SerializeField]
    private UIControl uiControl;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        SetHintMode(HintButtonMode.normal);
    }

    public void SetHintMode(HintButtonMode mode)
    {
        hintMode = mode;
        HintModeChanged(hintMode);
    }

    private void HintModeChanged(HintButtonMode mode)
    {
        switch (mode)
        {
            case HintButtonMode.normal:
                uiControl.ActionUISetActuveFalse();
                break;
            case HintButtonMode.see:
                uiControl.ActionBrickOfTrue();
                break;
            case HintButtonMode.shake:
                break;
            case HintButtonMode.touch:
                uiControl.ActionTextHintOfTrue();
                break;
            default:
                break;
        }
    }
}
