using Project_2.Scripts.Controllers;

namespace Project_2.Scripts
{
    public class FastMovement : MoveBase
    {
        
        public override void Move(Charachter charachter)
        {
            charachter.speed.Value = 20f;
            base.Move(charachter);
        }
    }
}