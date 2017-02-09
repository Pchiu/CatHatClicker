using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.AbstractClasses;
using Assets.Scripts.Enums;
using Assets.Scripts.GameEntities;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class ObjectManager : MonoBehaviour
    {
        public List<Cat> Cats;
        public Cat PrimaryCat;

        public void StartGame()
        {
            Cats = new List<Cat>();
            PrimaryCat = SpawnCat("cat", new Vector2(0, 0), 0);
        }

        public long CalculateClickValue()
        {
            long value = 0;
            foreach (var cat in Cats)
            {
                value += cat.Value;
            }
            return value;
        }

        public void AddCat(Cat cat, Vector2 position, Quaternion rotation)
        {
            Cats.Add((Cat)Instantiate(cat, position, rotation));
        }

        public Cat SpawnCat(string name, Vector2 position, float rotation)
        {
            GameObject catObject = Instantiate(Resources.Load("Prefabs/" + name), position, Quaternion.AngleAxis(rotation, Vector3.forward)) as GameObject;
            Cats.Add(catObject.GetComponent<Cat>());
            return catObject.GetComponent<Cat>();
        }

        public Hat SpawnHat(string name, Vector2 position, float rotation)
        {
            GameObject hatObject = Instantiate(Resources.Load("Prefabs/" + name), position, Quaternion.AngleAxis(rotation, Vector3.forward)) as GameObject;
            return hatObject.GetComponent<Hat>();
        }

        public void AddHatToPrimaryCat()
        {
            if (!PrimaryCat.HasOpenAttachmentPoint(AttachmentType.Head))
            {
                return;
            }
            var hat = SpawnHat("hat", new Vector2(0, 0), 0);
            PrimaryCat.AddAttachment(hat);
            GameController.Instance.SetClickValue(CalculateClickValue());
        }
    }
}
