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
    private GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        cubes = new GameObject[gridSizeX*gridSizeY];
        for(int height = 0; height < gridSizeY; height++)
        {
            for(int width = 0; width < gridSizeX; width++)
            {
                    cubes[width] = Instantiate<GameObject>(cube, new Vector3(0 - width*5,0,0 + height*5), Quaternion.identity);
                    cubes[width].gameObject.transform.SetParent(this.transform);
                    cubes[width].gameObject.transform.localScale*=cubeSize;
                    cubes[width].gameObject.name = "Cube";
               
            }
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
