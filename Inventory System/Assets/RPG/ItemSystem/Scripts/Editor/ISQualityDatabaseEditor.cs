using UnityEditor;
using UnityEngine;
using System.Collections;

namespace RPG.ItemSystem.Editor
{
    public class ISQualityDatabaseEditor : EditorWindow 
    {
		ISQualityDatabase db;

		const string DATABASE_FILE_NAME = @"rpgQualityDatabase.asset";
		const string DATABASE_FOLDER_NAME = @"Database";
		const string DATABASE_FULL_PATH = @"Assets/"+ DATABASE_FOLDER_NAME +"/" + DATABASE_FILE_NAME;

		[MenuItem ("RPG/Database/Quality Editor")]
		public static void Init ()
		{
			ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor> ();
			window.minSize = new Vector2 (400, 300);
			window.title = "Quality Database";
			window.Show ();
		}

		void OnEnable()
		{
			db = AssetDatabase.LoadAssetAtPath (DATABASE_FULL_PATH, typeof(ISQualityDatabase)) as ISQualityDatabase;

			if (db == null) 
			{
				if (!AssetDatabase.IsValidFolder("Asset/" + DATABASE_FOLDER_NAME))
				AssetDatabase.CreateFolder("Assets", DATABASE_FOLDER_NAME);

			    db = ScriptableObject.CreateInstance<ISQualityDatabase>();
			    AssetDatabase.CreateAsset(db,DATABASE_FULL_PATH);
			    AssetDatabase.SaveAssets();
				AssetDatabase.Refresh();
		    }
		}
	}
}