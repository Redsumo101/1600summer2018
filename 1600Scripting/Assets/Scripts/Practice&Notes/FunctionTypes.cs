using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTypes : MonoBehaviour {

	void NoReturnType()
	{
		//Do Work
		}

	void VoidWithParams(string s, string t)
	{
		//Do Work with s andb t
		
	}

	int NameOfFunction()
	{
		//must return the same data type as the funtion int in this situation
		return 0;
	}

	GameObject returnGameObject(GameObject obj)
	{
		return obj;
	}
	//corroutine 
	IEnumerator CorroutineName()
	{
		//DoWork
		yield return new WaitForSeconds(1);
		// Do More Work
	}
}
