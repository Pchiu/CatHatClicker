using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.AbstractClasses;
using Assets.Scripts.Controllers;
using Assets.Scripts.Enums;
using Assets.Scripts.Infrastructure;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.GameEntities
{
    public class Cat : AbstractClickable
    {
        public string Name;
        public Rarity Rarity;
        public CatType Type;
        public long Cost;
        public long Value;
        public long BaseValue;
        public string Description;
        public List<AttachmentPoint> AttachmentPoints;

        public void Start()
        {
            if (AttachmentPoints == null)
            {
                AttachmentPoints = new List<AttachmentPoint>();
            }
            UpdateValue();
        }

        public void Update()
        {

        }


        public override void OnMouseDown()
        {
            base.OnMouseDown();
            Debug.Log("Clicked on " + Name);
        }        

        public void UpdateValue()
        {
            var value = BaseValue;
            foreach (var attachmentPoint in AttachmentPoints)
            {
                if (attachmentPoint.Attachment != null)
                {
                    value *= (long)attachmentPoint.Attachment.Multiplier;
                }
            }
            Value = value;
        }

        public bool AddAttachment(Attachment attachment)
        {
            var openAttachmentPoint = AttachmentPoints.FirstOrDefault(ap => ap.Type == attachment.Type && ap.Attachment == null);
            if (openAttachmentPoint == null)
            {
                return false;
            }
            openAttachmentPoint.Attachment = attachment;
            attachment.transform.position = transform.position + new Vector3(openAttachmentPoint.transform.position.x, openAttachmentPoint.transform.position.y, -1) + new Vector3(attachment.Origin.x, attachment.Origin.y, 0);
            UpdateValue();
            return true;
        }

        public bool HasOpenAttachmentPoint(AttachmentType type)
        {
            return AttachmentPoints.FirstOrDefault(ap => ap.Type == type && ap.Attachment == null) != null;
        }
    }
}
