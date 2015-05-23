using UnityEngine;
using System.Collections;

namespace RPG.ItemSystem
{
	public interface IISObject 
	{
	string ISName { get; set; }
	int ISValue { get; set; }
	Sprite ISIcon { get; set; }
	int ISBurden { get; set; }
	ISQuality ISQuality { get; set; }

	//These go to other item interfaces
	//questitem flag
	//equip
	//durability
	//takedamage
	//prefab
	}
}