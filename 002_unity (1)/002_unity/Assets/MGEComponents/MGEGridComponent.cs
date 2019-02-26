using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[RequireComponent(typeof(GridComponent))]
public class MGEGridComponent : MGEComponent
{
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("GridComponent");
        GridComponent gridComponent = GetComponent<GridComponent>();
        Debug.Assert(gridComponent != null);

        component.SetAttribute("gridSizeX",gridComponent.GetGridSizeX().ToString());
        component.SetAttribute("gridSizeY",gridComponent.GetGridSizeY().ToString());
        component.SetAttribute("tileRadius",gridComponent.GetTileRadius().ToString());

        return component;
    }
}
