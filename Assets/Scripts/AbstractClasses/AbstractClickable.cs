using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Controllers;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.AbstractClasses
{
    public abstract class AbstractClickable : MonoBehaviour, IClickable
    {
        public virtual void Awake()
        {
            
        }

        public virtual void OnMouseDown()
        {
            GameController.Instance.Click();
        }

        public virtual void OnClick()
        {
            
        }
    }
}
