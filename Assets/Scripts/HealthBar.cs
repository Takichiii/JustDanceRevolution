using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private float vie;

    public void barreDeVie(int precision)
    {
        float value = 0.0F;
        if (precision < 0)
        {
            value = -10.0F; //pas rété
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

