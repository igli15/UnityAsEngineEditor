using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGEPlayerMovement : MGEComponent
{
    [Range(0,1.5f)]
    public float speed;

    public float slowDownAmount = 0.5f;

    public float speedUpAmount = 1.0f;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("PlayerMovement");
        component.SetAttribute("speed",speed.ToString());
        component.SetAttribute("slowDownAmount",slowDownAmount.ToString());
        component.SetAttribute("speedUpAmount",speedUpAmount.ToString());
        return component;
    }
}
