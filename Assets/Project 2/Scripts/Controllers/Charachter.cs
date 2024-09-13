using System;
using DG.Tweening;
using Obvious.Soap;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Project_2.Scripts.Controllers
{
    public class Charachter : MonoBehaviour
    {
        [Header("FSM")] private FormMachine _machine;
        [Header("Configuration")] public GameObject cube;
        public GameObject Sphere;
        public GameObject Capsule;
        public string AreaName = "";

        public MoveBase movment;

        public FloatVariable speed;

        public float duration;

        public Ease ease;
        [SerializeField] private ScriptableEventNoParam onButtonPressd;
        public ScriptableEventNoParam buttonEvent;


        void Start()
        {
            _machine = new FormMachine(this);
            _machine.Initialization(StateFactory.Creat(this,"capsule"));
            movment = new FastMovement();
            Area.OnAreaEnter += GetAreaName;

           
        }


        private void OnDisableButton(Button obj)
        {
            buttonEvent?.Raise();
        }

        private void GetAreaName(string name)
        {
            AreaName = name;
        }

        private void OnDisable()
        {
            Area.OnAreaEnter -= GetAreaName;
        }


        void Update()
        {
            _machine.Update();
        }

        private void FixedUpdate()
        {
            movment.Move(this);
        }

        public void ApplyCube()
        {
            _machine.ChangeTo(StateFactory.Creat(this,"cube"));
           

        }

        void EnableButton()
        {
            
        } 
        
        public void ApplySphere()
        {
            _machine.ChangeTo(StateFactory.Creat(this,"sphere"));
        }

        public void ApplyCapsule()
        {
            _machine.ChangeTo(StateFactory.Creat(this,"capsule"));
        }

        public void ReduiceScaleAnimation(GameObject shape, float duration, Ease ease)
        {
            var seq = DOTween.Sequence();
            seq.Append(shape.transform.DOScale(new Vector3(.1f, .1f, .1f), duration)
                .SetEase(ease)).OnComplete(() =>
                {
                    if (shape)
                    {
                        shape.SetActive(false); 
                    }
                   
                    
                }
            );
        }

        public void IncreaseScaleAnimation(GameObject shape, float duration, Ease ease)
        {
            var seq = DOTween.Sequence();
            seq.Append(shape.transform.DOScale(new Vector3(1f, 1f, 1f), duration)
                .SetEase(ease).OnStart(() => shape.SetActive(true))
            );
        }
    }
}