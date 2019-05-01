using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;
    
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
    
}
