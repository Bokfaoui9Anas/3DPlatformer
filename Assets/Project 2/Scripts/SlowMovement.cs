using Project_2.Scripts.Controllers;

namespace Project_2.Scripts
{
    public class SlowMovement : MoveBase
    {
        public override void Move(Charachter charachter)
        {
            charachter.speed.Value = 10f;
            base.Move(charachter);
        }
    }
}