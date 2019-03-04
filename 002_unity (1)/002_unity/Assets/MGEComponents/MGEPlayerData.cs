using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGEPlayerData : MGEComponent
{
    public int playerNumber = 2;

    public Transform respawnTransform;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("PlayerData");
        component.SetAttribute("playerNumber",playerNumber.ToString()); 

        Vector3 pos = respawnTransform.position;
        pos.x *= -1;
        component.SetAttribute("respawnPosition",pos.ToString()); 
        return component;
    }
}
