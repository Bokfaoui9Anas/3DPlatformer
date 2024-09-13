using System.Collections.Generic;
using UnityEngine;

namespace Project_2.Scripts.Controllers
{
    public static class StateFactory
    {
        public static IState Creat(Charachter charachter,string name)
        {
            Dictionary<string, IState> dict = new Dictionary<string, IState>();
            if (dict.ContainsKey(name))
            {
                return dict[name];
            }
            else
            {
                dict.Add(name,new CapsuleState(charachter));
            }

            switch (name)
            {
                
                case "cube":
                    foreach (var v in dict)
                    {
                        Debug.Log(v.Key);
                    }

                    return new CubeState(charachter);
                case "sphere":
                    return new SphereState(charachter);
                case "capsule":
                    return new CapsuleState(charachter);
                default:
                    return null;
            }
           
        
          
           
        }
    }
}