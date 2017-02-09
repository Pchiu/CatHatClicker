using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.AbstractClasses;
using Assets.Scripts.Enums;
using UnityEngine;

namespace Assets.Scripts.Infrastructure
{
    public class AttachmentPoint : MonoBehaviour
    {
        public Vector2 Origin;
        public AttachmentType Type;
        public Attachment Attachment;
    }
}
