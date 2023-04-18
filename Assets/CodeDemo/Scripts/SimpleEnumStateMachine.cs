using UnityEngine;

public class SimpleEnumStateMachine
{
    public enum State
    { 
        NULL,
        Start,
        End
    }

    public State CurrentState { get; private set; }

    public void GoToDefaultState()
    {
        SwitchState(State.Start);
    }

    public void SwitchState(State newState)
    {
        if (CurrentState == newState)
        {
            Debug.LogWarning("Can't enter -" + newState.ToString() + "- allready in this state");
            return;
        }

        CurrentState = newState;

        switch (newState)
        {
            case State.NULL:
                break;
            case State.Start:
                OnStart();
                break;
            case State.End:
                break;
        }
    }

    private void OnStart()
    {
        //DO Something
    }
}
