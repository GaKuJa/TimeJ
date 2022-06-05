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
        question = Difficulty.easy;//question��diffiulty��easy����(������)�����leasy

    }
    public Difficulty GetQuestion()
    {
        return question;//��Փx��߂�l�ɂ��ĕԂ��B
    }

    public void NormalButton()
    {
        question = Difficulty.normal;//�{�^���������ꂽ��question��diffiulty��normal����
    }

    public void HardButton()
    {
        question = Difficulty.hard;//question��diffiulty��hard����
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }




}
