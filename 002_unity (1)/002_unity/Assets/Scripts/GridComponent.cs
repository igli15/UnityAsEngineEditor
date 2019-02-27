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
    private float tileRadius;
    
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
                    cubes[width] = Instantiate<GameObject>(cube, new Vector3(0 - width*tileRadius*2,0,0 + height*tileRadius*2), Quaternion.identity);
                    cubes[width].gameObject.transform.SetParent(this.transform);
                    cubes[width].gameObject.transform.localScale*=tileRadius*2;
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
        return tileRadius;
    }

}
