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
        question = Difficulty.easy;//question��diffiulty��easy����

    }
    public Difficulty GetQuestion()
    {
        return question;
    }

    public void NormalButton()
    {
        question = Difficulty.normal;//question��diffiulty��normal����
    }

    public void HardButton()
    {
        question = Difficulty.hard;//question��diffiulty��hard����
    }

    private void StartButton()
    {
        SceneManager.LoadScene("SampleScene");//�����̃V�[��(��Փx���)������Ă������ɃX�N���v�g�A�{�^����u���Asamplescene���̂��̂͏�������B
    }




}
