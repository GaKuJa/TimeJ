using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BlackCurtainControl : MonoBehaviour
{
    [FormerlySerializedAs("BlackCurtain")]
    [SerializeField]
    private Image blackCurtain;

    public Action ActionBlackCurtainOfTrue  = new Action(() => { });
    public Action ActionBlackCurtainOfFalse = () => {};

    private void Start()
    {
        ActionBlackCurtainOfTrue  = BlackCurtainOfTrue;
        ActionBlackCurtainOfFalse = BlackCurtainOfFalse;
    }

    private void BlackCurtainOfTrue()
    {
        blackCurtain.gameObject.SetActive(true);
    }

    private void BlackCurtainOfFalse()
    {
        blackCurtain.gameObject.SetActive(false);
    }
}
