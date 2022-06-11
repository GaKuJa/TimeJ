using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyTextControl : MonoBehaviour
{
    [SerializeField]
    private Text difficultyText = null;

    [SerializeField]
    private QuestionCase questionCase;
    private void Update()
    {
        Debug.Log(questionCase.GetQuestion());
        difficultyText.text = questionCase.GetQuestion().ToString();
    }
}
