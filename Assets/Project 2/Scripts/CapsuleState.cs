using Project_2.Scripts.Controllers;
using UnityEngine;

namespace Project_2.Scripts
{
    public class CapsuleState : IStateShape
    {
        private Charachter _charachter;

        public CapsuleState(Charachter charachter)
        {
            this._charachter = charachter;
        }

        public void Enter()
        {
            _charachter.IncreaseScaleAnimation(_charachter.Capsule, _charachter.duration, _charachter.ease);
        }

        public void Update()
        {
            if (_charachter.AreaName != "sahara")
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
            _charachter.ReduiceScaleAnimation(_charachter.Capsule, _charachter.duration, _charachter.ease);
        }
    }
}