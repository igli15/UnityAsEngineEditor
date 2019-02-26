using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGEColorMaterial : MGEComponent
{

    public string materialName;

    public float shininess = 16;

    public Color diffuseColor = Color.white;


    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("ColorMaterial");
        component.SetAttribute("materialName",materialName);
        component.SetAttribute("shininess",shininess.ToString());

        Vector3 color = new Vector3(diffuseColor.r,diffuseColor.g,diffuseColor.b);
        component.SetAttribute("diffuseColor",color.ToString());

        return component;
    }
}
