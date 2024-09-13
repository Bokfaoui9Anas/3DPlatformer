using DG.Tweening;
using Project_2.Scripts.Controllers;
using UnityEngine;

namespace Project_2.Scripts
{
    public class CubeState : IStateShape
    {
        private Charachter _charachter;


        public CubeState(Charachter charachter)
        {
            this._charachter = charachter;
        }


        public void Enter()
        {
            
            _charachter.IncreaseScaleAnimation(_charachter.cube, _charachter.duration, _charachter.ease);

           
        }

        public void Update()
        {
            if (_charachter.AreaName != "solid")
            {
                _charachter.movment = new SlowMovement();
            }
            else
            {
                _charachter.movment = new FastMovement();
            }
        }

        public void Exit()
        {
            _charachter.ReduiceScaleAnimation(_charachter.cube, _charachter.duration, _charachter.ease);
        }
    }
}