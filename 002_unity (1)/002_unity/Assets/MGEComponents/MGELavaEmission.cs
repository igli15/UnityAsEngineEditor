using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGELavaEmission : MGEComponent
{
   public override XmlElement ParseSelf(XmlDocument pScene)
    {
         XmlElement component = pScene.CreateElement("LavaEmission");
         return component;
    }
}
