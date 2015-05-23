using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace RPG.ItemSystem
{
    public class ISQualityDatabase : ScriptableObject 
	{
		//[SerializeField]
		public List<ISQuality> db = new List<ISQuality> ();
    }
}