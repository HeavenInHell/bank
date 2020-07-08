using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cashier : MonoBehaviour
{
public static bool ProcessRequest()

	{
        System.Random rnd = new System.Random();
        if (rnd.Next(100) > 50)
            return true;
        return false;
    }
}
