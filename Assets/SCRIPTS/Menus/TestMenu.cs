using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMenu : MonoBehaviour
{
	public PageController pgController;

#if UNITY_EDITOR

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.O))
		{
			pgController.TurnOnPage(PageType.Loading);
		}
		if (Input.GetKeyUp(KeyCode.P))
		{
			pgController.TurnOffPage(PageType.Loading);
		}
		if (Input.GetKeyUp(KeyCode.K))
		{
			pgController.TurnOffPage(PageType.Loading, PageType.Menu);
		}
		if (Input.GetKeyUp(KeyCode.L))
		{
			pgController.TurnOffPage(PageType.Loading, PageType.Menu, true);
		}
	}

#endif
}
