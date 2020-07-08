using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Person : MonoBehaviour
{
    System.Random rnd = new System.Random();

    private int balance;
    
    private List<Request> listOfRequest = new List<Request>();

    public void MakeRequest()
    {
        Request newRequest = new Request();
        newRequest.typeServise =rnd.Next(5);
        listOfRequest.Add(newRequest);
        Debug.Log(newRequest.typeServise);
    }

   public void FindOutTheBalance()
    { }

   public void FindOutStateSevice()
    { }

}
