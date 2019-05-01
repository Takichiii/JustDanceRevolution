using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//objet modélisant une classe mobile
//objects modelizing a moving tile
public class MovingTile : MonoBehaviour
{
    private GameObject colorPrefab;
    private GameObject movingTile;
    private float xTile;
    private float speed = 3F;

    void Start()
    {
        movingTile = GameObject.Instantiate(colorPrefab, new Vector3(xTile, 0.5f, 5f), Quaternion.identity);
    }

    void Update()
    {
        //translater la case jusqu'à une limite
        if (movingTile.transform.position.z < -0.32f)
        {
            Destroy(movingTile);
        }
        movingTile.transform.Translate(Vector3.forward*Time.deltaTime*-speed);
    }

    //interpretateTilePropertiesCodin
    //create a moving tile knowing parameters of color(0, 1 or 2) and corridor (0, 1, or 2)
    public void Init(int color, int corridor, int foot)
    {
        switch (color)
        {
            case 0:
                colorPrefab = Resources.Load("prefab/blueTilePrefab") as GameObject;
                break;
            case 1:
                colorPrefab = Resources.Load("prefab/pinkTilePrefab") as GameObject;
                break;
            case 2:
                colorPrefab = Resources.Load("prefab/greenTilePrefab") as GameObject;
                break;
            default:
                colorPrefab = Resources.Load("prefab/blueTilePrefab") as GameObject;
                break;
        }

        switch (corridor)
        {
            case 0:
                this.xTile = -0.32f;
                break;
            case 1:
                this.xTile = 0;
                break;
            case 2:
                this.xTile = 0.32f;
                break;
            default:
                this.xTile = 0.32f;
                break;
        }
    }
}
