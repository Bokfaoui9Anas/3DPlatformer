using DG.Tweening;
using Project_2.Scripts;
using Project_2.Scripts.Controllers;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Project_2.Scripts
{
    public class SphereState : IStateShape
    {
        private Charachter _charachter;

        public SphereState(Charachter charachter)
        {
            this._charachter = charachter;
        }

        public void Enter()
        {
            _charachter.IncreaseScaleAnimation(_charachter.Sphere, _charachter.duration, _charachter.ease);
           
        }

        public void Update()
        {
            if (_charachter.AreaName != "liquid")
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
            _charachter.ReduiceScaleAnimation(_charachter.Sphere, _charachter.duration, _charachter.ease);
        }
    }
}