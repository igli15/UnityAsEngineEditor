using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGELightComponent : MGEComponent
{
    public enum LightType
    {
        DIRECTIONAL,
        POINT,
        SPOTLIGHT
    }

    public LightType type;

    public Color color;

    public Color ambientColor;

    public float intensity = 1;

    public float ambientContribution = 0.5f;

    public float specularContribution = 0.3f;

    public Vector3 attenuationConstants;

    public float cutoffAngle = 10;

    public float outercutoffAngle = 45;


    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("LightComponent");
        component.SetAttribute("type",type.ToString());

        Vector3 c = new Vector3(color.r,color.g,color.b);
        Vector3 ac = new Vector3(ambientColor.r,ambientColor.g,ambientColor.b);
        component.SetAttribute("color",c.ToString());
        component.SetAttribute("ambientColor",ac.ToString());
        component.SetAttribute("intensity",intensity.ToString());
        component.SetAttribute("ambientContribution",ambientContribution.ToString());
        component.SetAttribute("specularContribution",specularContribution.ToString());
        component.SetAttribute("attenuationConstants",attenuationConstants.ToString());
        component.SetAttribute("cutoffAngle",cutoffAngle.ToString());
        component.SetAttribute("outercutoffAngle",outercutoffAngle.ToString());
        return component;
    }
}
