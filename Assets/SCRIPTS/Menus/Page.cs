using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{
    public static readonly string FLAG_ON = "ON";
    public static readonly string FLAG_OFF = "OFF";
    public static readonly string FLAG_NONE = "None";

    public PageType type;
    public bool UseAnimation;
    public string TargetState { get; private set; }
    private Animator m_Anim;

	#region Unity_Function

	private void OnEnable()
	{
		
	}

	#endregion

	#region Public_Function

	public void Animate(bool _On)
	{

	}

	#endregion

	#region Private_Function

	private IEnumerator AwaitAnimation(bool _On)
	{
		yield return null;
	}

	private void CheckAnimatorIntegrity()
	{

	}

	private void Log(string _msg)
	{

	}

	private void LogWarning(string _msg)
	{

	}
	#endregion
}
