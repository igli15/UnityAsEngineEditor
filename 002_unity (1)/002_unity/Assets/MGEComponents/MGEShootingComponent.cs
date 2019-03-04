using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGEShootingComponent : MGEComponent
{
    public int minRange = 2;
    public int maxRange = 6;

    public int inkMaxLevel = 100;

    public float rateOfInkGain = 0.1f;

    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("ShootingComponent");
        component.SetAttribute("minRange",minRange.ToString());
        component.SetAttribute("maxRange",maxRange.ToString());
        component.SetAttribute("inkMaxLevel",inkMaxLevel.ToString());
        component.SetAttribute("rateOfInkGain",rateOfInkGain.ToString());

        return component;
    }
}
