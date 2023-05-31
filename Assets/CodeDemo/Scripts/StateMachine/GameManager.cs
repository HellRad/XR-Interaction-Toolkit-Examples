using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStates
{
    NONE,
    Ingame,
    GameOver
}

public class GameManager : MonoBehaviour
{
    public GameStates StartState;
    public GameStates CurrentState { get; private set; }

    public static GameManager Instance;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogWarning($"There was more then one instance of {this.GetType().Name} deleting additional instance");
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        if (StartState == GameStates.NONE)
        {
            GoToDefaultState();
        }
        else
        {
            SwitchGameState(StartState);
        }
    }

    public void GoToDefaultState()
    {
        SwitchGameState(GameStates.Ingame);
    }

    public void SwitchGameState(GameStates newState)
    {
        if (CurrentState == newState)
        {
            //debug
            return;
        }

        CurrentState = newState;

        switch (newState)
        {
            case GameStates.NONE:
                break;
            case GameStates.Ingame:
                //do things when entering ingame.
                break;
            case GameStates.GameOver:
                ShowGameOverScreen();
                break;
            default:
                break;
        }
    }

    void ShowGameOverScreen()
    {

    }
}
