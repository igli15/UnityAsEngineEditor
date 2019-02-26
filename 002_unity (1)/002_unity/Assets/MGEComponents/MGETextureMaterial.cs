using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGETextureMaterial : MGEComponent
{
    
    public string materialName;

    public float shininess = 16;

    [Range(0,1)]
    public float emissionScale = 0.8f;

    public string diffuseTextureName = "NONE";
    public string specularTextureName = "NONE";

    public string emissionTextureName = "NONE";

    public string normalTextureName = "NONE";

    public Color diffuseColor = Color.white;

    public override XmlElement ParseSelf(XmlDocument pScene)
    {
         XmlElement component = pScene.CreateElement("TextureMaterial");
        component.SetAttribute("materialName",materialName);
        component.SetAttribute("shininess",shininess.ToString());
        component.SetAttribute("emissionScale",emissionScale.ToString());

        component.SetAttribute("diffuseTexture",diffuseTextureName);
        component.SetAttribute("specularTexture",specularTextureName);
        component.SetAttribute("emissionTexture",emissionTextureName);
        component.SetAttribute("normalTexture",normalTextureName);

        Vector3 color = new Vector3(diffuseColor.r,diffuseColor.g,diffuseColor.b);
        component.SetAttribute("diffuseColor",color.ToString());

        return component;
    }
}
