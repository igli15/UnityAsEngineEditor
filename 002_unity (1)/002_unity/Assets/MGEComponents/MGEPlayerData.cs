using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGEPlayerData : MGEComponent
{
    public int playerNumber = 2;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("PlayerData");
        component.SetAttribute("playerNumber",playerNumber.ToString());
        return component;
    }
}
