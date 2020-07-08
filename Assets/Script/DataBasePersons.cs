using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBasePersons : MonoBehaviour
{
    public InputField ifield;
   public Text namePerson;
    public static Person currentPerson;
    static Dictionary<string, Person> DataBase =
    new Dictionary<string, Person>();

    public void NameEnter()
    {
        //Debug.Log(namePerson.text);
       
        bool check = false;
        foreach (KeyValuePair<string, Person> person in DataBase)
        {
            if (person.Key == namePerson.text)
            {
                check = true;
                currentPerson = person.Value;
            }
        }

        if (check)
        {
            Debug.Log("клиент найден");
        }
        else
        {
            Person newPerson = new Person();
            newPerson.namePerson = namePerson.text;
           

            DataBase.Add(namePerson.text, newPerson);
            Debug.Log(namePerson.text+ " новый клиент");
            currentPerson = newPerson;
        }
     
    }



}
