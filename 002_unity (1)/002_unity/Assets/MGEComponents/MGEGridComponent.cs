using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[RequireComponent(typeof(GridComponent))]


public class MGEGridComponent : MGEComponent
{
    public Transform[] ballonTiles;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("GridComponent");
        GridComponent gridComponent = GetComponent<GridComponent>();
        Debug.Assert(gridComponent != null);

        component.SetAttribute("gridSizeX",gridComponent.GetGridSizeX().ToString());
        component.SetAttribute("gridSizeY",gridComponent.GetGridSizeY().ToString());
        component.SetAttribute("tileRadius",gridComponent.GetTileRadius().ToString());

         XmlElement ballonTransforms = pScene.CreateElement("BallonTilePositions");

        component.AppendChild(ballonTransforms);

        foreach(Transform t in ballonTiles)
        {
            XmlElement e = pScene.CreateElement("ballonTile");
            e.SetAttribute("pos",t.position.ToString("N4"));
            ballonTransforms.AppendChild(e);
        }

        return component;
    }
}
