using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        question = Difficulty.easy;//questionにdiffiultyのeasyを代入(初期化)初期値easy

    }
    public Difficulty GetQuestion()
    {
        return question;//難易度を戻り値にして返す。
    }

    public void NormalButton()
    {
        question = Difficulty.normal;//ボタンが押されたらquestionにdiffiultyのnormalを代入
    }

    public void HardButton()
    {
        question = Difficulty.hard;//questionにdiffiultyのhardを代入
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }




}
