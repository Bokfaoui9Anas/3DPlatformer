using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Obvious.Soap;
using Project_PlayerState.Scripts.Pattern.State;
using UnityEngine;

public class ChooserController : MonoBehaviour
{

    
    public ChooserMachine machine;
    public GameObject[] players;
    public List<Vector3> playerInitialPosition;
    public bool isWaitFinish = false;
    [SerializeField] public float waitTime = 1f;
    public BoolVariable isEmpty;
    public MoveStrategy moveStrategy;

    public Transform PosPresenter
    {
        get => posPresenter;
        set => posPresenter = value;
    }

    [SerializeField] private Transform posPresenter;

    private void Awake()
    {
     //  moveStrategy = new MoveStrategyImpl();
     moveStrategy = new MoveSequenceStrategyImpl();
    }


    private void Start()
    {
        foreach (var V in players)
        {
            playerInitialPosition.Add(V.transform.position);
        }
        
        machine = new ChooserMachine(this);
        machine.Initialisation(machine._P1);
    }

    private void Update()
    {
     
        machine.Update();
       
        
    }

   
    

   
    
    
    
}