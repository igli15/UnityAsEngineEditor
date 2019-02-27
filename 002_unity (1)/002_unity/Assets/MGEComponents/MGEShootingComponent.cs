using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGEShootingComponent : MGEComponent
{
    public int shootingRange = 3;

    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("ShootingComponent");
        component.SetAttribute("shootingRange",shootingRange.ToString());
        return component;
    }
}
