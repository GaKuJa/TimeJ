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
        question = Difficulty.easy;//questionにdiffiultyのeasyを代入

    }
    public Difficulty GetQuestion()
    {
        return question;
    }

    public void NormalButton()
    {
        question = Difficulty.normal;//questionにdiffiultyのnormalを代入
    }

    public void HardButton()
    {
        question = Difficulty.hard;//questionにdiffiultyのhardを代入
    }

    private void StartButton()
    {
        SceneManager.LoadScene("SampleScene");//自分のシーン(難易度画面)を作ってそっちにスクリプト、ボタンを置き、samplescene内のものは消去する。
    }




}
