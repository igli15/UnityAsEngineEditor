using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[RequireComponent(typeof(GridComponent))]

public class MGEGridComponent : MGEComponent
{
    public float playerPosOffsetX = 0.2f;
    public float playerPosOffsetY = 0.3f;
    public float balloonSpawnTime = 10;
    public Transform[] ballonTiles;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("GridComponent");
        GridComponent gridComponent = GetComponent<GridComponent>();
        Debug.Assert(gridComponent != null);

        component.SetAttribute("gridSizeX",gridComponent.GetGridSizeX().ToString());
        component.SetAttribute("gridSizeY",gridComponent.GetGridSizeY().ToString());
        component.SetAttribute("tileRadius",gridComponent.GetTileRadius().ToString());

        component.SetAttribute("playerPosOffsetX",playerPosOffsetX.ToString());
        component.SetAttribute("playerPosOffsetY",playerPosOffsetY.ToString());
        component.SetAttribute("balloonSpawnTime",balloonSpawnTime.ToString());

        XmlElement ballonTransforms = pScene.CreateElement("BallonTilePositions");

        component.AppendChild(ballonTransforms);

        Vector3 ballonPos = Vector3.zero;
        foreach(Transform t in ballonTiles)
        {
            XmlElement e = pScene.CreateElement("ballonTile");
            ballonPos = t.transform.position;
            ballonPos.x *= -1;
            e.SetAttribute("pos",ballonPos.ToString("N4"));
            ballonTransforms.AppendChild(e);
        }

        return component;
    }
}
