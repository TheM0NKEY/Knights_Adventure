using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FloorTile : Tile 
{
	[SerializeField]
	private Sprite[] floorSprites;

	[SerializeField]
	private Sprite preview;

	public override void GetTileData(Vector3Int position, ITilemap tilemap,ref TileData tileData)
	{
		int randomVal = Random.Range(0, 100);

		if (randomVal < 16)
		{
			tileData.sprite = floorSprites[0];
		}
		else if (randomVal >= 16 && randomVal < 33)
		{

			tileData.sprite = floorSprites[1];
		}
		else if (randomVal >= 33 && randomVal < 49)
		{
			tileData.sprite = floorSprites[2];
		}
		else if (randomVal >= 49 && randomVal < 66)
		{
			tileData.sprite = floorSprites[3];
		}
		else if (randomVal >= 66 && randomVal < 83)
		{
			tileData.sprite = floorSprites[4];
		}
		else
		{
			tileData.sprite = floorSprites[5];
		}
	}

	private bool IsSame(ITilemap tilemap, Vector3Int position)
	{
		return tilemap.GetTile (position) == this;
	}

#if UNITY_EDITOR
	[MenuItem("Assets/Create/Tiles/FloorTile")]
	public static void createFloorTile()
	{
		string path = EditorUtility.SaveFilePanelInProject ("Save Floortile", "New Floortile", "asset", "Save Floortile", "Assets");
		if (path == "") 
		{
			return;
		}
		AssetDatabase.CreateAsset (ScriptableObject.CreateInstance<FloorTile> (), path);

	}

	#endif
	
}
