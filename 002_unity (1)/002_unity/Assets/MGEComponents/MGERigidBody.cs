using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGERigidBody : MGEComponent
{
    [Range(0,1)]
    public float friction = 0;

    public float maxSpeed = 0.5f;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("RigidBodyComponent");
        component.SetAttribute("friction",friction.ToString());
        component.SetAttribute("maxSpeed",maxSpeed.ToString());
        return component;
    }
    
}
