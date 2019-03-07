using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGERefillStation : MGEComponent
{
    public float inkGainRate=0.1f;
    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("RefillStationComponent");
        component.SetAttribute("inkGainRate", inkGainRate.ToString());
        return component;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
