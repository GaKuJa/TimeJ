using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionCase : MonoBehaviour
{

    public enum Difficulty
    {
        easy,
        normal,
        hard,
    }

    Difficulty question = Difficulty.easy;

    public void EasyButton()
    {
        question = Difficulty.easy;//question‚Édiffiulty‚Ìeasy‚ð‘ã“ü
        Debug.Log(question);
    }

    public void NormalButton()
    {
        question = Difficulty.normal;//question‚Édiffiulty‚Ìnormal‚ð‘ã“ü
        Debug.Log(question);
    }

    public void HardButton()
    {
        question = Difficulty.hard;//question‚Édiffiulty‚Ìhard‚ð‘ã“ü
        Debug.Log(question);
    }


    private void Update()
    {
        
    }




}
