using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public void ChangeS()
	{
		SceneManager.LoadScene("Services");
	}
	public void Back()
	{
		SceneManager.LoadScene("EnterName");
	}
}