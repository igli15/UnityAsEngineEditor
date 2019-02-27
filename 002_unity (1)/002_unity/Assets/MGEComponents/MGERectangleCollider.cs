using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGERectangleCollider : MGEComponent
{
    public float width = 1;
    public float height = 1;

    public string collisionLayer;

    public string[] collisionFilters;

    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("RectangleCollider");
        component.SetAttribute("width",width.ToString());
        component.SetAttribute("height",height.ToString());
        component.SetAttribute("collisionLayer",collisionLayer);
        
        XmlElement filters = pScene.CreateElement("CollisionFilters");

        component.AppendChild(filters);

        foreach(string s in collisionFilters)
        {
            XmlElement e = pScene.CreateElement(s);
            filters.AppendChild(e);
        }


        return component;
    }
}
