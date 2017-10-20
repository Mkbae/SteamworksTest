using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class SteamScript : MonoBehaviour
{
	private void Start()
	{
		string n = SteamFriends.GetPersonaName();
		Debug.Log(n);
	}
}