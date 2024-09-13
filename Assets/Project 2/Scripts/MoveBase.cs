using Obvious.Soap;
using Project_2.Scripts.Controllers;
using Unity.VisualScripting;
using UnityEngine;

namespace Project_2.Scripts
{
    public abstract  class  MoveBase
    {
    //  protected  FloatVariable Speed ;
        public virtual void Move(Charachter charachter)
        {
            charachter.transform.position += charachter.transform.forward *  charachter.speed * Time.deltaTime;
            
        }
        
    }
}