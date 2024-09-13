using UnityEngine;
using DG.Tweening;
using Obvious.Soap;
using Unity.VisualScripting;

public class P1 : IChooser
{
    private ChooserController _chooserController;
 
  
    
    //private BoolVariable _isEmpty;


    public P1(ChooserController chooserController)
    {
        this._chooserController = chooserController;
    }

  
    

    public void Enter()
    {
        


        Debug.Log("P1 enter");
        _chooserController.moveStrategy.move(_chooserController,0,_chooserController.isEmpty);
       




    }

    public void Update()
    {
        
        if (_chooserController.isEmpty)
        {
             _chooserController.machine.ChangeState(new P2(_chooserController));
        }

       // Debug.Log(_isEmpty);
       
    }


    public void Exit()
    {
        
       _chooserController.isEmpty.Value = false;
        Debug.Log("P1 exite");
    }

    /*public void MoveStrategy(ChooserController chooserController,int pInt)
    {
        chooserController.players[pInt].transform.DOMove(chooserController.PosPresenter.position + new Vector3(0, 1, 0),
            chooserController.waitTime,
            false).OnComplete(() =>
        {
            chooserController.StateStart(_chooserController.waitTime);

            chooserController.players[pInt].transform.DOMove(chooserController.playerInitialPosition[pInt],
                1).SetEase(Ease.InOutSine).OnComplete(() =>
            {
                isEmpty = true;
                Debug.Log("Complete p1");


            });

        });
    }*/
}