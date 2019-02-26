using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
public abstract class MGEComponent : MonoBehaviour
{
   public abstract XmlElement ParseSelf(XmlDocument pScene);
   
}
