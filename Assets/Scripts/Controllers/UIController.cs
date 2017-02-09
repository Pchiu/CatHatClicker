using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
    public class UIController : MonoBehaviour
    {
        public Text MoneyCounter;
        public Button TestButton;
        public ObjectManager ObjectManager;

        void Start()
        {
            ObjectManager = GetComponent<ObjectManager>();
        }

        public void SetMoneyDisplay(long money)
        {
            MoneyCounter.text = "Money: " + money;
        }
    }
}
