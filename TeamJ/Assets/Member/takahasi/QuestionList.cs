using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class QuestionList : MonoBehaviour
{
    public Sprite maru;
    public Sprite batu;

    public Image image;
    public GameObject score = null;

    public void Start()
    {
        int[] Qestions = {0, 1};
        image = GameObject.Find("Image").GetComponent<Image>();
        image.enabled = false;

        for (int i = 0; i < Qestions.Length; i++)
        {
            if (Qestions[i] == 0)
            {
                image.enabled = true;
                image.sprite = maru;
            }

            if (Qestions[i] == 1)
            {
                image.enabled = true;
                image.sprite = batu;
            }


            Debug.Log(Qestions[i]);
        }
        //Qestions[0] = ;
        //Qestions[1] = ;
        //Qestions[2] = ;
        //Qestions[3] = ;
        //Qestions[4] = ;

    }

    public void Update()
    {
        //Text score_Text =  score.GetComponent<Text>();

        //score_Text.text = 
    }

}
