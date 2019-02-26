using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridComponent : MonoBehaviour
{
    [SerializeField]
    private int gridSizeX ;
    [SerializeField]
    private int gridSizeY;

    [SerializeField]
    private float cubeSize;
    
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private GameObject cube2;
    private GameObject[] cubes;
    private int counter =0;
    // Start is called before the first frame update
    void Start()
    {
        cubes = new GameObject[gridSizeX*gridSizeY];
        for(int height = 0; height < gridSizeY; height++)
        {
            for(int width = 0; width < gridSizeX; width++)
            {
                if(counter%2 == 0)
                {
                    cubes[width] = Instantiate<GameObject>(cube, new Vector3(0 - width*cubeSize*2,0,0 + height*cubeSize*2), Quaternion.identity);
                    cubes[width].gameObject.transform.localScale*=cubeSize;
                    cubes[width].gameObject.name = "Cube";
                } 
                else
                { 
                    cubes[width] = Instantiate<GameObject>(cube2, new Vector3(0 - width*cubeSize*2,0,0 + height*cubeSize*2), Quaternion.identity); 
                    cubes[width].gameObject.transform.localScale*=cubeSize;
                    cubes[width].gameObject.name = "Cube";
                }
                counter++;
            }
            counter++;
        }
    }

    public int GetGridSizeX()
    {
        return gridSizeX;
    }

     public int GetGridSizeY()
    {
        return gridSizeY;
    }

    public float GetTileRadius()
    {
        return cubeSize;
    }

}
