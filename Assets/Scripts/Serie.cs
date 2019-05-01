using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor.SceneManagement;
using UnityEngine;
using Random = System.Random;

//classe modélisant un enchainement de cases mobiles séparées par une distance donnée
//class modelizing a serie of moving tiles separated by a given distance
public class Serie : MonoBehaviour
{
    private MovingTile tile;
    private float distance = 1f; //distance between two consecutive tiles
    private String serieCode; //chosen serie of tiles
    private int index; //index in serieString

    // Start is called before the first frame update
    void Start()
    {
        this.index = 0;
        this.serieCode = "1211211001211001210001211001211001211001212001211001211001" +
                         "11110110110110111111111111100121100121100121100121100121111" +
                         "110110110110111111111111100121100121100121100121110101101111" +
                         "120110101111120";
        InvokeRepeating("getNextTile", 2.0f, distance);
    }

    private void getNextTile()
    {
        int color = serieCode[index];
        int corridor = serieCode[index + 1];
        int foot = serieCode[index + 2];
        tile = gameObject.AddComponent<MovingTile>();
        tile.Init(color, corridor, foot); //this does not retrieve the good tile
        //tile.Init(1, 0,0); // this works
        index += + 3;
    }

    //TODO : test
    //initialize serie randomly (nTiles=64 typically )
    public void Init(int nTiles)
    {
        int length = nTiles * 3;
        Random random = new Random();
        const string chars = "012";
        this.serieCode = new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
    
    //TODO : test path = "choregraphies/choreo1.txt"
    //initialize a serie using a file
    public void Init(String path)
    {
        this.serieCode = File.ReadAllText(path);
    }
    

}
