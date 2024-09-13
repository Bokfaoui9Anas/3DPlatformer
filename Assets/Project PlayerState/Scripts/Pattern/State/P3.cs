using DG.Tweening;
using UnityEngine;

public class P3 : IChooser
{
    
    private ChooserController _chooserController;
   
  

    public P3(ChooserController chooserController)
    {
        this._chooserController = chooserController;
    }
    public void Enter()
    {
        Debug.Log("P3 enter");
        _chooserController.moveStrategy.move(_chooserController,2,_chooserController.isEmpty);


    }

    public void Update()
    {
        
        if (_chooserController.isEmpty)
        {
            _chooserController.machine.ChangeState(new P1(_chooserController));
        }
    }

    public void Exit()
    {
        _chooserController.isEmpty.Value = false;
        Debug.Log("P3 exite");

    }
}