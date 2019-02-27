using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGEPlayerMovement : MGEComponent
{
    [Range(0,1.5f)]
    public float speed;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("PlayerMovement");
        component.SetAttribute("speed",speed.ToString());
        return component;
    }
}
