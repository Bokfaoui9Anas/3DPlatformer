using DG.Tweening;
using Obvious.Soap;
using UnityEngine;

namespace Project_PlayerState.Scripts.Pattern.State
{

    public class MoveSequenceStrategyImpl : MoveStrategy
    {
        public void move(ChooserController chooserController, int pInt, BoolVariable isEmpty)
        {
        
            var seq = DOTween.Sequence();
            seq.Append(chooserController.players[pInt].transform.DOMove(chooserController.PosPresenter.position + new Vector3(0, 1, 0),
                1,
                false));
            seq.Append(DOVirtual.Float(0f,chooserController.waitTime,chooserController.waitTime, value =>
            {
             
            }).SetEase(Ease.InCubic));
            seq.Append(chooserController.players[pInt].transform.DOMove(chooserController.playerInitialPosition[pInt],
                1).SetEase(Ease.InOutSine).OnComplete(() =>
                {
                    isEmpty.Value = true;
                    
                }));
        }
    }
    
    
}