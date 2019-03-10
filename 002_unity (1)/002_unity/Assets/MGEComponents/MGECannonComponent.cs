using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MGECannonComponent : MGEComponent
{
    private enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    public int shootingRange = 4;

    public override XmlElement ParseSelf(XmlDocument pScene)
    {
         XmlElement component = pScene.CreateElement("CannonComponent");
         component.SetAttribute("shootingRange",shootingRange.ToString());

        float dot =Vector3.Dot(transform.forward,Vector3.forward);
        Direction dir;

        if(dot > 0.7f) dir = Direction.UP;
        else if(dot < -0.7f) dir = Direction.DOWN;
        else
        {
            float hDot = Vector3.Dot(transform.forward,Vector3.right);
            if(hDot > 0f) dir = Direction.RIGHT;
            else dir = Direction.LEFT;
        }
    
        component.SetAttribute("FacingDir",dir.ToString());

         return component;
    }
}
