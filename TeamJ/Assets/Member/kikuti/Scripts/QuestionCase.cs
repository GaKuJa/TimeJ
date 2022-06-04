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
        question = Difficulty.easy;//questionにdiffiultyのeasyを代入
        Debug.Log(question);
    }

    public void NormalButton()
    {
        question = Difficulty.normal;//questionにdiffiultyのnormalを代入
        Debug.Log(question);
    }

    public void HardButton()
    {
        question = Difficulty.hard;//questionにdiffiultyのhardを代入
        Debug.Log(question);
    }


    private void Update()
    {
        
    }




}
