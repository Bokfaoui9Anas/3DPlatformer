using Project_2.Scripts.Controllers;
using Unity.VisualScripting;

namespace Project_2.Scripts
{
    public class FormMachine : FSM
    {
        public IStateShape Spher => _spher;

        public IStateShape Cube => _cube;

        public IStateShape Capsule => _capsule;

        private IState _currentState;
        private IStateShape _spher;
        private IStateShape _cube;
        private IStateShape _capsule;

        public FormMachine(Charachter charachter)
        {
            this._cube = new CubeState(charachter);
            this._spher = new SphereState(charachter);
            this._capsule = new CapsuleState(charachter);
        }

        public override void Initialization(IState state)
        {
            _currentState = state;
            _currentState.Enter();
        }

        public override void ChangeTo(IState newState)
        {
            _currentState.Exit();
            _currentState = newState;
            newState.Enter();
        }

        public override void Update()
        {
            _currentState?.Update();
        }
    }
}