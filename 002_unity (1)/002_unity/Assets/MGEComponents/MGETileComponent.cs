using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGETileComponent : MGEComponent
{
    public enum TileType
    {
        DEFAULT,
        ICE,
        LAVA
    }

    public TileType tileType = TileType.DEFAULT;

    public bool isPaintable = true;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
         XmlElement component = pScene.CreateElement("TileComponent");
         component.SetAttribute("TileType",tileType.ToString());
         component.SetAttribute("isPaintable",isPaintable.ToString());

         return component;
    }
}
