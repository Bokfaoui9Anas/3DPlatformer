



using UnityEngine;

public class IdleState : ILocomotionState
{
    private PlayerController _playerController;
    private float speed = 5f;


    public IdleState(PlayerController playerController)
    {
        this._playerController = playerController;
    }

    public void Enter()
    {
        Debug.Log("Idle Enter");
    }

    public void Update()
    {
        var move = new Vector3(_playerController.MoveInput().x,0,_playerController.MoveInput().z) * speed * Time.deltaTime;
        _playerController.gameObject.transform.position += move;
        Debug.Log(move);
        if (_playerController.MoveInput().magnitude == 0)
        {
            _playerController.LocomotionMachine.ChangeState(_playerController.LocomotionMachine.Walk);
        }

    }
    public void Exit()
    {
        Debug.Log("Idle Exit");
    }

 
}