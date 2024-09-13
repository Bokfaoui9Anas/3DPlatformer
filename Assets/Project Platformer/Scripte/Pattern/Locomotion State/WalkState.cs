using UnityEngine;

public class WalkState : ILocomotionState
{
    private PlayerController _playerController;

    public WalkState(PlayerController playerController)
    {
        this._playerController = playerController;
    }

    public void Enter()
    {
        Debug.Log("Walk Enter");
    }

    public void Update()
    {
  
        if (_playerController.MoveInput().magnitude != 0)
        {
            _playerController.LocomotionMachine.ChangeState(_playerController.LocomotionMachine.Idle);
        }
    }

    public void Exit()
    {
        Debug.Log("Walk Exit");
    }

  

   
}