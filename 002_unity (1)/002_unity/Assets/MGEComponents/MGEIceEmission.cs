using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGEIceEmission : MGEComponent
{
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
         XmlElement component = pScene.CreateElement("IceEmission");

         return component;
    }
}
