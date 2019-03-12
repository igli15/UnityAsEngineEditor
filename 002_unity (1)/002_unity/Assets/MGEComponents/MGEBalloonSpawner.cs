using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGEBalloonSpawner : MGEComponent
{

    public bool spawnOnStart = false;

    public float spawnTime = 5;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
       XmlElement component = pScene.CreateElement("BalloonSpawner");
       component.SetAttribute("spawnOnStart",spawnOnStart.ToString());
       component.SetAttribute("spawnTime",spawnTime.ToString());

       return component;
    }
}
