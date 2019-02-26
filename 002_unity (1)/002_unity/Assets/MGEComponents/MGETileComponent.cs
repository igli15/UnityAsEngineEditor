using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGETileComponent : MGEComponent
{
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
         XmlElement component = pScene.CreateElement("TileComponent");
         return component;
    }
}
