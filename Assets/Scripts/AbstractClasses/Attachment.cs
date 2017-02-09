using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Enums;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.AbstractClasses
{
    public abstract class Attachment : AbstractClickable
    {
        public AttachmentType Type;
        public Vector2 Origin;
        public float Multiplier;
        public string Name;
        public string Description;
        public Rarity Rarity;
        public long Cost;
    }
}
