using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    //My Birthday is October 13th 
    public int birthdayMonth = 10;
    public int birthdayDay = 13;

    void Start()
    {
        // This will be the months
        for (int month = 1; month <= 12; month++)
        {
            if (month == birthdayMonth)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(month);
            }
        }

        // leaps year months
        if (birthdayMonth == 2) 
        {
            for (int day = 1; day <= 29; day++)
            {
                if (day == birthdayDay)
                {
                    Debug.Log("It's my birthday!");
                }
                else
                {
                    Debug.Log(day);
                }
            }
        }
        else if (birthdayMonth == 4 || birthdayMonth == 6 || birthdayMonth == 9 || birthdayMonth == 11) //Apr,Jun,Sep & Nov have 30 days
        {
            for (int day = 1; day <= 30; day++)
            {
                if (day == birthdayDay)
                {
                    Debug.Log("It's my birthday!");
                }
                else
                {
                    Debug.Log(day);
                }
            }
        }
        else // 31 for the rest 
        {
            for (int day = 1; day <= 31; day++)
            {
                if (day == birthdayDay)
                {
                    Debug.Log("It's my birthday!");
                }
                else
                {
                    Debug.Log(day);
                }
            }
        }
    }
}
