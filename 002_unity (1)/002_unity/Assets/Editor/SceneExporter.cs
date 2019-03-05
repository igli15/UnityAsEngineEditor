using System;
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

        //RETARDS COMMENT YOUR PATHS!!!!

        //string mgePath = @"D:\Den Haag\Program Files (x86)\Project3rdPerson\mge_v18_student_version\assets\mge\scenes\" + scene.name + ".xml";
        //string mgePath = @"C:\Users\Igli\Desktop\Project-Third-Person\mge_v18_student_version\assets\mge\scenes\" + scene.name + ".xml";
        string mgePath = @"D:\SchoolWork\Year2\Quartile3\project\engine\mge_v18_student_version\assets\mge\scenes\" + "scene"+ ".xml";

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
		node.SetAttribute("position", position.ToString("N4"));

		Quaternion rotation = pTransform.localRotation;
        rotation.y *= -1;
        rotation.z *= -1;
		node.SetAttribute("rotation", rotation.ToString("N4"));

		node.SetAttribute("scale", pTransform.localScale.ToString("N4"));

		MeshFilter mesh = pTransform.GetComponent<MeshFilter>();
		
		if (mesh != null)
		{
			node.SetAttribute("mesh", pTransform.tag != "Untagged"?pTransform.tag: "cubeMesh");
		}

		return node;
	}
}
