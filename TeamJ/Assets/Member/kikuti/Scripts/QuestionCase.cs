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
        question = Difficulty.easy;//question��diffiulty��easy����
        Debug.Log(question);
    }

    public void NormalButton()
    {
        question = Difficulty.normal;//question��diffiulty��normal����
        Debug.Log(question);
    }

    public void HardButton()
    {
        question = Difficulty.hard;//question��diffiulty��hard����
        Debug.Log(question);
    }


    private void Update()
    {
        
    }




}
