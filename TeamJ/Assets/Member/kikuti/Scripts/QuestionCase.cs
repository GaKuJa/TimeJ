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
        Debug.Log(question);
    }
    
    public void NormalButton()
    {
        question = Difficulty.normal;//�{�^���������ꂽ��question��diffiulty��normal����
        Debug.Log(question);
    }

    public void HardButton()
    {
        question = Difficulty.hard;//question��diffiulty��hard����
        Debug.Log(question);
    }
    
    public Difficulty GetQuestion()
    {
        return question; //��Փx��߂�l�ɂ��ĕԂ��B
    }

    public void StartButton()
    {
        SceneManager.LoadScene("MainGameScene");
    }




}
