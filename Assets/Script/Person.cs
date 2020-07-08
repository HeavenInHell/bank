using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Person : MonoBehaviour
{
    

    private int balance;
    public string namePerson;
    public DataBasePersons dBP;
    private List<Request> listOfRequest = new List<Request>();
    private List<Usluga> listOfUsluga = new List<Usluga>();

    public void MakeRequestOnCard()
    {
        Request newRequest = new Request();
        newRequest.typeServise = "Card";
        newRequest.StateService = Cashier.ProcessRequest();
        //Debug.Log(newRequest.StateService);
        listOfRequest.Add(newRequest);
        if(newRequest.StateService)
        {
            Usluga usluga = new Usluga();
                usluga.typeUsluga = newRequest.typeServise;
            listOfUsluga.Add(usluga);
        }
            
    }

    public void MakeRequestOnLoan()
    {
        Request newRequest = new Request();
        newRequest.typeServise = "Loan";
        newRequest.StateService = Cashier.ProcessRequest();
        //Debug.Log(newRequest.StateService);
        listOfRequest.Add(newRequest);
        if (newRequest.StateService)
        {
            Usluga usluga = new Usluga();
            usluga.typeUsluga = newRequest.typeServise;
            listOfUsluga.Add(usluga);
        }

    }

    public void MakeRequestOnDeposit()
    {
        Request newRequest = new Request();
        newRequest.typeServise = "Deposit";
        newRequest.StateService = Cashier.ProcessRequest();
        //Debug.Log(newRequest.StateService);
        listOfRequest.Add(newRequest);
        if (newRequest.StateService)
        {
            Usluga usluga = new Usluga();
            usluga.typeUsluga = newRequest.typeServise;
            listOfUsluga.Add(usluga);
        }

    }

    public void StateRequests()
    {
        Debug.Log("Requests person " + namePerson);
        int k = 1;
        foreach(Request request in listOfRequest)
        {

            Debug.Log(k+" "+request.StateService +" "+ request.typeServise);
            k++;
        }
    }

   public void FindOutTheBalance()
    {
        Debug.Log(namePerson + " balance: " + balance);
    }

   public void FindOutStateSevice()
    {
        Debug.Log("Services person " + namePerson);
        int k = 1;
        foreach (Usluga usluga in listOfUsluga)
        {

            Debug.Log(k + " " + usluga.typeUsluga);
            k++;
        }
    }



    public void EnterName()
    {
        Debug.Log(namePerson);
    }

}
