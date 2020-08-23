using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	/// <summary>
	/// Singleton
	/// </summary>
    public static GameManager instance = null; //Declaring and initialzing a public static manager class to null. 
    public int HP = 3;

	private void Awake()
	{
		if(instance == null) //determines if our instance is null.
		{
			instance = this; //assign instance to this instance of the class. 
		}
		else if(instance != null) //Determines if our instance is already assigned to something else. 
		{
			Destroy(gameObject); //since we already have a manager assigned somewhere else, we dont need duplicate. 
		}
	}
}
