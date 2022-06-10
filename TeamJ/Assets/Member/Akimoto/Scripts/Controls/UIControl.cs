using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer brick;

    [SerializeField]
    private Text textHint;

    public Action ActionUISetActuveFalse = new Action(() => { });
    public Action ActionBrickOfTrue     = new Action(() => { });
    public Action ActionTextHintOfTrue  = new Action(() => { });

    private void Start()
    {
        ActionBrickOfTrue      = BrickOfTrue;
        ActionTextHintOfTrue   = TextHintOfTrue;
        ActionUISetActuveFalse = UISetActiveFalse;
    }

    private void UISetActiveFalse()
    {
        brick.gameObject.SetActive(false);
        textHint.gameObject.SetActive(false);
    }

    public void BrickOfTrue()
    {
        brick.gameObject.SetActive(true);
    }

    public void TextHintOfTrue()
    {
        textHint.gameObject.SetActive(true);
    }
}
