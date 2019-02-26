using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGECircleCollider : MGEComponent
{
    public float radius = 1;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("CircleCollider");
        component.SetAttribute("radius",radius.ToString());
        return component;
    }
}
