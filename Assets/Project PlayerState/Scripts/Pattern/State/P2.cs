using DG.Tweening;
using UnityEngine;

public class P2 : IChooser
{
    
    private ChooserController _chooserController;
   

    public P2(ChooserController chooserController)
    {
        this._chooserController = chooserController;
    }
    public void Enter()
    {
       
       
        
        _chooserController.moveStrategy.move(_chooserController,1,_chooserController.isEmpty);

        Debug.Log("P2 enter");
      
        


    }

    public void Update()
    {
        if (_chooserController.isEmpty)
        {
            _chooserController.machine.ChangeState(new P3(_chooserController));
        }
    }

    public void Exit()
    {
        _chooserController.isEmpty.Value = false;
        
        Debug.Log("P2 exite");
    }
}