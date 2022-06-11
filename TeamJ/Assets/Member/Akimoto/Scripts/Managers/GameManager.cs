using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    Start,
    Playing,
    HintTime,
    AnswerTime,
    resultTime,
    End,
}

public class GameManager : MonoBehaviour
{
    public static  GameManager Instance { get => _instance; }
    private static GameManager _instance;

    [SerializeField]
    private BlackCurtainControl blackCurtainControl;
    [SerializeField]
    private static GameState       currentGameState;

    private void Awake()
    {
        _instance = this;
        SetCurrentState(GameState.Start);
    }

    public void SetCurrentState(GameState state)
    {
        currentGameState = state;
        OnGameStateChanged(currentGameState);
    }

    private void OnGameStateChanged(GameState state)
    {
        switch (state)
        {
            case GameState.Start:
                break;
            case GameState.Playing:
                blackCurtainControl.ActionBlackCurtainOfFalse();
                break;
            case GameState.HintTime:
                blackCurtainControl.ActionBlackCurtainOfTrue();
                break;
            case GameState.AnswerTime:
                ChangeAnswerScene();
                break;
            case GameState.resultTime:
                blackCurtainControl.ActionBlackCurtainOfTrue();
                break;
            case GameState.End:
                break;
            default:
                break;
        }
    }

    private void ChangeAnswerScene()
    {
        SceneManager.LoadScene("AnswerScene");
    }
    
    public GameState GetGameState()
    {
        return currentGameState;
    }
}
