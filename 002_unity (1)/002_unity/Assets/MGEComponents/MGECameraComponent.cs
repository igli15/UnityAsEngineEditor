using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGECameraComponent : MGEComponent
{

    public float FOV = 60.0f;
    public float aspectRatio = 4.0f/3.0f;

    public float nearClipPlane = 0.1f;

    public float farClipPlane = 1000.0f;


    public override XmlElement ParseSelf(XmlDocument pScene)
    {
        XmlElement component = pScene.CreateElement("CameraComponent");
        component.SetAttribute("FOV",FOV.ToString());
        component.SetAttribute("aspectRatio",aspectRatio.ToString());
        component.SetAttribute("nearClipPlane",nearClipPlane.ToString());
        component.SetAttribute("farClipPlane",farClipPlane.ToString());
        return component;
    }
}
