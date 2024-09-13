namespace Project_2.Scripts
{
    public abstract class FSM
    {
        public abstract void Initialization(IState state);
        public abstract void ChangeTo(IState newState);
        public abstract void Update();

    }
}