using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateBase : ScriptableObject, IGameState {
	public virtual void Run()
	{
	Debug.Log("Running");	
	}
	
}
//makes requirements for other scripts
public interface IGameState
{
	void Run();
}