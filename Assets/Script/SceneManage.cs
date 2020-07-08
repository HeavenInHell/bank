using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage : MonoBehaviour
{
    public void ClickOnButton1()
	{
		DataBasePersons.currentPerson.FindOutTheBalance();
	}
    public void ClickOnButton3()
	{
		DataBasePersons.currentPerson.MakeRequestOnCard();
	}
    public void ClickOnButton()
    {
        DataBasePersons.currentPerson.StateRequests();
    }

    public void ClickOnButton4()
    {
        DataBasePersons.currentPerson.FindOutStateSevice();
    }

    public void ClickOnButton5()
    {
        DataBasePersons.currentPerson.MakeRequestOnLoan();
    }

    public void ClickOnButton6()
    {
        DataBasePersons.currentPerson.MakeRequestOnDeposit();
    }

}
