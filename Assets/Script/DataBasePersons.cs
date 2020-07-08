using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBasePersons : MonoBehaviour
{
    public InputField ifield;
   public Text namePerson;
    Dictionary<string, Person> DataBase =
    new Dictionary<string, Person>();

    public void nameEnter()
    {
        Debug.Log(namePerson.text);
        bool check = false;
        foreach (KeyValuePair<string, Person> person in DataBase)
        {
            if (person.Key == namePerson.text)
            {
                check = true;
                Debug.Log(person.Key, person.Value);
            }
        }

        if (check)
        {

        }
        else
        {
            Person newPerson = new Person();
            DataBase.Add(namePerson.text, newPerson);
        }


    }
}
