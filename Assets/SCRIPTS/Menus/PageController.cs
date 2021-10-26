using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageController : MonoBehaviour
{
	//Whenever we need a singleton object that should run only one instance at a time, we use the singleton method with static variable.
	public static PageController instance;
	//For Checking whether the obj which we are running is properly running or not.
	public bool Debug;
	//Starting page of our Menu.
	public PageType EntryPage;
	//List or Array Collection of all pages that Menu Consists.
	public Page[] pages;
	//Private Variable that contain 
	private Hashtable m_Pages;

	#region Unity_Function
	private void Awake()
	{
		
	}
	#endregion

	#region Public_Functions
	public void TurnOnPage(PageType _Type)
	{

	}
	
	public void TurnOffPage(PageType Off, PageType On = PageType.None, bool WaitForExit = false)
	{

	}
	#endregion

	#region Private_Function

	private IEnumerator WaitForPageExit(Page _On, Page _Off)
	{
		yield return null;
	}

	private void RegisterAllPage()
	{

	}

	private void RegisterPage(Page _page)
	{

	}

	private Page GetPage(PageType _Type)
	{
		return null;
	}

	private bool PageExists(PageType _Type)
	{
		return false;
	}

	private void Log(string _msg)
	{

	}

	private void LogWarning(string _msg)
	{

	}
	#endregion
}
