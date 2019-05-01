using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System.Timers;
using Random = System.Random;
using UnityEngine.SocialPlatforms.Impl;


public class move_case : MonoBehaviour
{
    private int score;
    private float vie;
    public GameObject blue;
    public GameObject purple;
    public GameObject green;
    public float defaultSpeed = 0.03F;
    GameObject newCase;
    public List<int[]> pasDance = new List<int[]>();
    public int index;
    private DateTime time;
    public List<GameObject> allCases;

    public Random rnd = new Random();

    // Start is called before the first frame update
    void Start()
    {
        //newCase = Instantiate(prefab, new Vector3(0.32F,0,10), Quaternion.identity);
        score = 0;
        vie = 100.0F;
        pasDance.Add(new int []{1,2,1,1});
        pasDance.Add(new int []{1,2,1,2});
        pasDance.Add(new int []{1,0,0,3});
        pasDance.Add(new int []{1,2,1,4});
        pasDance.Add(new int []{1,0,0,5});
        pasDance.Add(new int []{1,2,1,6});
        pasDance.Add(new int []{0,0,0,7});
        pasDance.Add(new int []{1,2,1,8});
        pasDance.Add(new int []{1,0,0,9});
        pasDance.Add(new int []{1,2,1,10});
        pasDance.Add(new int []{1,0,0,11});
        pasDance.Add(new int []{1,2,1,12});
        pasDance.Add(new int []{1,0,0,13});
        pasDance.Add(new int []{1,2,1,14});
        pasDance.Add(new int []{2,0,0,15});
        pasDance.Add(new int []{1,2,1,16});
        pasDance.Add(new int []{1,0,0,17});
        pasDance.Add(new int []{1,2,1,18});
        pasDance.Add(new int []{1,0,0,19});
        pasDance.Add(new int []{1,1,1,20});
        pasDance.Add(new int []{1,1,0,21});
        pasDance.Add(new int []{1,1,0,22});
        pasDance.Add(new int []{1,1,0,23});
        pasDance.Add(new int []{1,1,0,24});
        pasDance.Add(new int []{1,1,1,25});
        pasDance.Add(new int []{1,1,1,26});
        pasDance.Add(new int []{1,1,1,27});
        pasDance.Add(new int []{1,1,1,28});
        pasDance.Add(new int []{1,0,0,29});
        pasDance.Add(new int []{1,2,1,30});
        pasDance.Add(new int []{1,0,0,31});
        pasDance.Add(new int []{1,2,1,32});
        pasDance.Add(new int []{1,0,0,33});
        pasDance.Add(new int []{1,2,1,34});
        pasDance.Add(new int []{1,0,0,35});
        pasDance.Add(new int []{1,2,1,36});
        pasDance.Add(new int []{1,0,0,37});
        pasDance.Add(new int []{1,2,1,38});
        pasDance.Add(new int []{1,1,1,39});
        pasDance.Add(new int []{1,1,0,40});
        pasDance.Add(new int []{1,1,0,41});
        pasDance.Add(new int []{1,1,0,42});
        pasDance.Add(new int []{1,1,0,43});
        pasDance.Add(new int []{1,1,1,44});
        pasDance.Add(new int []{1,1,1,45});
        pasDance.Add(new int []{1,1,1,46});
        pasDance.Add(new int []{1,1,1,47});
        pasDance.Add(new int []{1,0,0,48});
        pasDance.Add(new int []{1,2,1,49});
        pasDance.Add(new int []{1,0,0,50});
        pasDance.Add(new int []{1,2,1,51});
        pasDance.Add(new int []{1,0,0,52});
        pasDance.Add(new int []{1,2,1,53});
        pasDance.Add(new int []{1,0,0,54});
        pasDance.Add(new int []{1,2,1,55});
        pasDance.Add(new int []{1,1,0,56});
        pasDance.Add(new int []{1,0,1,57});
        pasDance.Add(new int []{1,0,1,58});
        pasDance.Add(new int []{1,1,1,59});
        pasDance.Add(new int []{1,2,0,60});
        pasDance.Add(new int []{1,1,0,61});
        pasDance.Add(new int []{1,0,1,62});
        pasDance.Add(new int []{1,1,1,63});
        pasDance.Add(new int []{1,2,0,64});
        allCases = new List<GameObject>();
        index = 0;
        time = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        //if(newCase.transform.position.z >= -10)
          //  newCase.transform.Translate(-Vector3.forward*defaultSpeed);
       GenerateChoree();
       PlayChoree();
    }


    private void GenerateChoree()
    {
        if (index < pasDance.Count)
        {
            //int timeGeneration = pasDance[index][3];
            //TimeSpan timeItTook = DateTime.Now - time;
            TimeSpan timeItTook = DateTime.Now - time;
            int duration = Convert.ToInt32(timeItTook.TotalSeconds);

            if (index+2 <= duration && index < pasDance.Count)
            {

                int xRandom = rnd.Next(0, 3);
                int colorRandom = rnd.Next(0, 3);
                int feetRandom = rnd.Next(0, 3);
                
                /*float x = 0;
                newCase = new GameObject();
                if(pasDance[index][1] == 0){
                    x = -0.32F;
                }
                if(pasDance[index][1] == 1){
                    x = 0F;
                }
                if(pasDance[index][1] == 2){
                    x = 0.32F;
                }*/
                
                float x = 0;
                newCase = new GameObject();
                if(xRandom == 0){
                    x = -0.32F;
                }
                if(xRandom == 1){
                    x = 0F;
                }
                if(xRandom == 2){
                    x = 0.32F;
                }
                else
                {
                    print("bo");
                }
                print("ne");

                /*if (pasDance[index][0] == 0)
                {
                    newCase = Instantiate(blue, new Vector3(x,0,10), Quaternion.identity);
                }
                if (pasDance[index][0] == 1)
                {
                    newCase = Instantiate(purple, new Vector3(x,0,10), Quaternion.identity);
                }
                if (pasDance[index][0] == 2)
                {
                    newCase = Instantiate(green, new Vector3(x,0,10), Quaternion.identity);
                }*/
                
                if (colorRandom == 0)
                {
                    newCase = Instantiate(blue, new Vector3(x,0,10), Quaternion.identity);
                }
                if (colorRandom == 1)
                {
                    newCase = Instantiate(purple, new Vector3(x,0,10), Quaternion.identity);
                }
                if (colorRandom == 2)
                {
                    newCase = Instantiate(green, new Vector3(x,0,10), Quaternion.identity);
                }
                else
                {
                    print("bo");
                }
                print("ne");
                
                allCases.Add(newCase);
                index++;
            }
        }
        
        
    }
    
    private void PlayChoree(){
        for (var i = 0; i < allCases.Count; i++)
        {
            if(allCases[i].transform.position.z >= -10){
                allCases[i].transform.Translate(-Vector3.forward*defaultSpeed);
            }
            else
            {
                Destroy(allCases[i]);
                allCases.RemoveAt(i);
            }
        }
    }

    public int calculPrecision(int z1, int z2)
    {
        int precision = (int) 100-(Mathf.Abs(z1-z2)*100);
        return precision;
    }


    public void scorePerformance(int precision)
    {
        score += precision;

       
        if (precision >= 95)
        {
            print("Excellent!!!");
        }
        else
        {
            if (precision >= 70)
            {
                print("Good");
            }
            else
            {
                if(precision >= 30)
                    print("Not Bad");
                else
                {
                    print("Not Bad");
                }
            }
        }
        print("+"+precision);
    }
        
    public void barreDeVie(int precision)
    {
        float value = 0.0F;
        if (precision < 0)
        {
            value= -10.0F; //pas rété
            print("Cible ratée");
            print("-10");

        }
        else
        {
            if (precision >= 95)
            {
                value = 1.0F;
                print("Excellent!!!");
            }
            else
            {
                if (precision >= 70)
                {
                    value = 0.5F;
                    print("Good");
                }
                else
                {
                    if (precision >= 50)
                    {
                        value = 0.25F;
                        print("Not Bad");
                    }
                    else
                    {
                        if (precision >= 30)
                        {
                            value = 0.25F;
                            print("Not Bad");
                        }
                        else
                        {
                            value = 0.125F;
                            print("Not Bad");
                        }
                        
                    }
                }
            }
        }
        print("You got" + value);
        vie += value;
    }
    

   
}