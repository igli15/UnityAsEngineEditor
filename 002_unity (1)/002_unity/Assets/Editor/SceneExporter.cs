﻿using System;
using System.Xml;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneExporter : Editor {

	[MenuItem("ThirdPerson/ExportScene")]
	private static void ExportScene()
	{
		XmlDocument sceneXml = new XmlDocument();
		XmlElement rootElement = sceneXml.CreateElement("root");
		sceneXml.AppendChild(rootElement);

		Scene scene = SceneManager.GetActiveScene();
		GameObject[] gameObjects = scene.GetRootGameObjects();
		foreach (GameObject go in gameObjects) _process(go.transform, rootElement, sceneXml);

		string path = Application.dataPath + "/" + scene.name + ".xml";
		
		string mgePath = @"C:\Users\Igli\Desktop\Project-Third-Person\mge_v18_student_version\assets\mge\scenes\" + scene.name + ".xml";
		 
        sceneXml.Save(path);
		sceneXml.Save(mgePath);
        Debug.Log("File exported to :" + path);
		 Debug.Log("File exported to :" + mgePath);
	}

	private static void _process (Transform pTransform, XmlElement pParentElement, XmlDocument pScene)
	{
		XmlElement convertedElement = _convert(pTransform, pScene);
		pParentElement.AppendChild(convertedElement);

		foreach (Transform child in pTransform)
		{
			_process(child, convertedElement, pScene);
		}
	}

	private static XmlElement _convert (Transform pTransform, XmlDocument pScene)
	{
		XmlElement node = pScene.CreateElement("GameObject");
		node.SetAttribute("name", pTransform.name);

        XmlElement comNode = pScene.CreateElement("Components");
        node.AppendChild(comNode);

        //XmlElement test = pScene.CreateElement("TestComponent");
        //comNode.AppendChild(test);
		MGEComponent[] components = pTransform.GetComponents<MGEComponent>();

		foreach(var com in components)
		{
			XmlElement e = com.ParseSelf(pScene);
			comNode.AppendChild(e);
		}

        Vector3 position = pTransform.localPosition;
        position.x *= -1;
		node.SetAttribute("position", position.ToString());

		Quaternion rotation = pTransform.localRotation;
        rotation.y *= -1;
        rotation.z *= -1;
		node.SetAttribute("rotation", rotation.ToString());

		node.SetAttribute("scale", pTransform.localScale.ToString());

		MeshFilter mesh = pTransform.GetComponent<MeshFilter>();
		
		if (mesh != null)
		{
			node.SetAttribute("mesh", pTransform.tag != "Untagged"?pTransform.tag:"Cube");
		}

		return node;
	}
}
