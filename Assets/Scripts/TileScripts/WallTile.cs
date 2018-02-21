using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Tilemaps;

public class WallTile : Tile 
{
	[SerializeField]
	private Sprite[] wallSprites;

	[SerializeField]
	private Sprite preview;


	public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
	{
		return base.StartUp(position, tilemap, go);
	}

	public override void RefreshTile(Vector3Int position, ITilemap tilemap)
	{
		for (int x = -1; x <= 1; x++) 
		{
			for (int y = -1; y <= 1; y++) 
			{
				Vector3Int nPos = new Vector3Int (position.x + x, position.y + y, position.z);

				if (IsSame (tilemap, nPos)) 
				{
					tilemap.RefreshTile (nPos);
				}
			}
		}
	}

	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tiledata)
	{
		base.GetTileData(position, tilemap, ref tiledata);

		string composition = string.Empty;

		for (int x = -1; x <= 1; x++) 
		{
			for (int y = -1; y <= 1; y++) 
			{
				if (x != 0 || y != 0)
				{
					if (IsSame(tilemap, new Vector3Int(position.x +x, position.y+y, position.z)))
					{
						composition += 'W';
					}
					else
					{
						composition += 'E';
					}
				}
			}
		}

		if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'E' && composition[6] == 'E') 
		{
			tiledata.sprite = wallSprites[0];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'E' && composition[6] == 'W') 
		{
			tiledata.sprite = wallSprites[1];
		} 
		else if (composition[1] == 'W' && composition[3] == 'E' && composition[4] == 'E' && composition[6] == 'W')
		{
			tiledata.sprite = wallSprites[2];
		}
		else if (composition[1] == 'W' && composition[3] == 'E' && composition[4] == 'E' && composition[6] == 'E') 
		{
			tiledata.sprite = wallSprites[3];
		} 

		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'E')
		{
			tiledata.sprite = wallSprites[4];
		}
		else if (composition[1] == 'E' && composition[4] == 'W' && composition[3] == 'W' && composition[6] == 'E')
		{
			tiledata.sprite = wallSprites[5];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[6] == 'E' && composition[4] == 'W')
		{
			tiledata.sprite = wallSprites[6];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'W')
		{
			tiledata.sprite = wallSprites[7];
		}
		else if (composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'E')
		{
			tiledata.sprite = wallSprites[8];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W')
		{
			tiledata.sprite = wallSprites[9];
		}
		else if (composition[1] == 'W' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'E')
		{
			tiledata.sprite = wallSprites[10];
		}
		else if (composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'W')
		{
			tiledata.sprite = wallSprites[11];
		}
		else if (composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'W')
		{
			tiledata.sprite = wallSprites[12];
		}
		else if (composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tiledata.sprite = wallSprites[13];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'W')
		{
			tiledata.sprite = wallSprites[14];
		}
		else if (composition[1] == 'W' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W')
		{
			tiledata.sprite = wallSprites[15];
		}

	}

	private bool IsSame(ITilemap tilemap, Vector3Int position)
	{
		return tilemap.GetTile (position) == true;
	}

	#if UNITY_EDITOR
	[MenuItem("Assets/Create/Tiles/WallTile")]
	public static void createWallTile()
	{
		string path = EditorUtility.SaveFilePanelInProject ("Save Walltile", "New Walltile", "asset", "Save Walltile", "Assets");
		if (path == "") 
		{
			return;
		}
		AssetDatabase.CreateAsset (ScriptableObject.CreateInstance<WallTile> (), path);
	}
	#endif
}
