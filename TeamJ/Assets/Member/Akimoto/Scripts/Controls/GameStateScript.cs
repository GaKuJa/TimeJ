using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateScript : MonoBehaviour
{
    // 問題番号
    private static int   quetionNum  = 0;
    // 答え用の配列
    private static int[]       answerArray          = new int[3]{0,0,0};
    public         Action<int> ActionSetAnswerArray = new Action<int>((result) => { });
    public         Action      ActionQuetionNumMass = new Action(() => { });
    public         Func<int>   FuncGetQuetionNum    = new Func<int>(() => { return quetionNum; });

    private void Start()
    {
        ActionQuetionNumMass = QuetionNumMass;
        ActionSetAnswerArray = SetAnswerArray;
        FuncGetQuetionNum    = GetQuetionNum;
    }

    private void SetAnswerArray(int result)
    {
        // 配列の問題番号目に結果を入れる
        answerArray[quetionNum] = result;
    }

    private int GetQuetionNum()
    {
        return quetionNum;
    }

    private void QuetionNumMass()
    {
        quetionNum++;
    }
    
    
}
