using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    class GameController : MonoBehaviour
    {
        public long Clicks;
        public long ClickValue;
        public long Money;
        public long Income;
        public float IncomeInterval;
        public float TimeSinceLastInterval;
        public ObjectManager ObjectManager;
        public UIController UIController;

        private static GameController instance;

        public static GameController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = GameObject.FindObjectOfType (typeof(GameController)) as GameController;
                }
                return instance;
            }
        }

        void Start()
        {
            UIController = GetComponent<UIController>();
            ObjectManager = GetComponent<ObjectManager>();
            StartGame();
        }

        void Update()
        {
            
        }

        public void Click()
        {
            Clicks += 1;
            Money += ClickValue;
            UIController.SetMoneyDisplay(Money);
        }

        public void SetClickValue(long value)
        {
            ClickValue = value;
        }

        public void StartGame()
        {
            Clicks = 0;
            Money = 0;
            ObjectManager.StartGame();
            ClickValue = ObjectManager.CalculateClickValue();
        }
    }
}
