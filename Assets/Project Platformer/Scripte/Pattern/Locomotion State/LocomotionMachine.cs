

public class LocomotionMachine
{
    public WalkState Walk
    {
        get => _walk;
        set => _walk = value;
    }

    public IdleState Idle
    {
        get => _idle;
        set => _idle = value;
    }

    public ILocomotionState CurrentState { get; private set; }
    private IdleState _idle;
    private WalkState _walk;

    public LocomotionMachine(PlayerController playerController)
    {
      _idle = new IdleState(playerController);
      _walk = new WalkState(playerController);

    }



    public void Initializaion(ILocomotionState state)
    {
        CurrentState = state;
        CurrentState.Enter();
    }

    public void ChangeState(ILocomotionState NewState)
    {
        CurrentState.Exit();
        CurrentState = NewState;
        NewState.Enter();
    }
    public void Update()
    {
        if (CurrentState != null)
        {
            CurrentState.Update();
        }
       
    }
}