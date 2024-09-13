using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private LocomotionMachine _locomotionMachine;

    public LocomotionMachine LocomotionMachine
    {
        get => _locomotionMachine;
        set => _locomotionMachine = value;
    }

    void Start()
    {
        _locomotionMachine = new LocomotionMachine(this);
        _locomotionMachine.Initializaion(_locomotionMachine.Idle);
    }

    void Update()
    {
        
        _locomotionMachine.Update();
    }
    
  

    public Vector3 MoveInput()
    {
        return new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
    }
}
