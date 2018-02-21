using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Tilemaps;

public class GroundTile : Tile {

	[SerializeField]
	private Sprite[] groundSprites;

	[SerializeField]
	private Sprite preview;


	public override void RefreshTile(Vector3Int position, ITilemap tilemap)
	{
		for (int x = -1; x <= 1; x++) 
		{
			for (int y = -1; y <= 1; y++) 
			{
				Vector3Int nPos = new Vector3Int (position.x + x, position.y + y, position.z);

				if (IsSame(tilemap, nPos))
				{
					tilemap.RefreshTile (nPos);
				}
			}
		}
	}

	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
	{
		string composition = string.Empty;

		for (int x = -1; x <= 1; x++)//Runs through all neighbours 
		{
			for (int y = -1; y <= 1; y++)
			{
				if (x != 0 || y != 0) //Makes sure that we aren't checking our self
				{
					//If the value is the same Groundtile
					if (IsSame(tilemap, new Vector3Int(position.x + x, position.y + y, position.z)))
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

		int randomVal = Random.Range(0, 100);

		if (randomVal < 15)
		{
			tileData.sprite = groundSprites[1];
		}
		/*else if (randomVal >= 15 && randomVal < 35)
		{

			tileData.sprite = groundSprites[48];
		}*/
		else
		{
			tileData.sprite = groundSprites[0];
		}

		//TODO Optimse this code

		if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'E' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[10];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'W' && composition[6] == 'W')
		{
			tileData.sprite = groundSprites[7];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'E' && composition[6] == 'W')
		{
			tileData.sprite = groundSprites[17];
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'W' && composition[6] == 'W')
		{
			tileData.sprite = groundSprites[2];
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[6];
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[18];
		}

		else if (composition[0] == 'E' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'W' && composition[6] == 'W')
		{
			tileData.sprite = groundSprites[1];
		}

		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[5] == 'W' && composition[6] == 'W' && composition[7] == 'W')
		{
			tileData.sprite = groundSprites[5];
		}

		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'W' && composition[5] == 'E' && composition[7] == 'W')
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[5] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			tileData.sprite = groundSprites[1];
		}

		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[5] == 'E' && composition[6] == 'W' && composition[7] == 'E')
		{
			tileData.sprite = groundSprites[24];
		}

		else if (composition[0] == 'E' && composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[1];
		}

		else if (composition[0] == 'W' && composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[3];
		}

		else if (composition[0] == 'W' && composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition[0] == 'W' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'E' && composition[6] == 'W')
		{
			tileData.sprite = groundSprites[1];
		}

		else if (composition[0] == 'E' && composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'W' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[23];
		}
		else if (composition[0] == 'E' && composition[1] == 'W' && composition[3] == 'W' && composition[4] == 'E' && composition[5] == 'E' && composition[6] == 'W')
		{
			tileData.sprite = groundSprites[22];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'W')
		{
			tileData.sprite = groundSprites[8];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			tileData.sprite = groundSprites[19];
		}
		else if (composition[1] == 'W' && composition[2] == 'W' && composition[4] == 'W' && composition[3] == 'E' && composition[6] == 'W' && composition[7] == 'W')
		{
			tileData.sprite = groundSprites[4];
		}

		else if (composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'W')
		{
			tileData.sprite = groundSprites[1];
		}

		else if (composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'W' && composition[7] == 'E')
		{
			tileData.sprite = groundSprites[25];
		}
		else if (composition[1] == 'W' && composition[2] == 'W' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[9];
		}
		else if (composition[1] == 'W' && composition[2] == 'E' && composition[3] == 'E' && composition[4] == 'W' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[20];
		}
		else if (composition[1] == 'W' && composition[3] == 'E' && composition[4] == 'E' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[13];
		}
		else if (composition[1] == 'E' && composition[3] == 'E' && composition[4] == 'E' && composition[6] == 'W')
		{
			tileData.sprite = groundSprites[11];
		}

		else if (composition[1] == 'W' && composition[3] == 'E' && composition[4] == 'E' && composition[6] == 'W')
		{
			if (randomVal < 15) 
			{
				tileData.sprite = groundSprites[12];
			} 
			else 
			{
				tileData.sprite = groundSprites [26];
			}
		}
		else if (composition[1] == 'E' && composition[4] == 'W' && composition[3] == 'W' && composition[6] == 'E')
		{
			if (randomVal < 15) 
			{
				tileData.sprite = groundSprites[15];
			} 
			else 
			{
				tileData.sprite = groundSprites [27];
			}
		}

		else if (composition[1] == 'E' && composition[3] == 'E' && composition[6] == 'E' && composition[4] == 'W')
		{
			tileData.sprite = groundSprites[16];
		}
		else if (composition[1] == 'E' && composition[3] == 'W' && composition[4] == 'E' && composition[6] == 'E')
		{
			tileData.sprite = groundSprites[14];
		}

		else if (composition == "EWWWWEWW")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "EWEWWWWE")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "EWEWWWWW")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "WWWWWEWW")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "WWEWWWWE")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "WWWWWWWE")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "EWWWWWWW")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "WWEWWWWW")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "EWWWWWWE")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "EWWWWEWE")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "WWWWWEWE")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "WWEWWEWW")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "EWEWWEWW")
		{
			tileData.sprite = groundSprites[1];
		}
		else if (composition == "WWEWWEWE")
		{
			tileData.sprite = groundSprites[1];
		}

		else if (composition == "EWEWWEWE")
		{
			tileData.sprite = groundSprites[21];
		}
	}

	private bool IsSame(ITilemap tilemap, Vector3Int position)
	{
		return tilemap.GetTile (position) == this;
	}

	#if UNITY_EDITOR
	[MenuItem("Assets/Create/Tiles/GroundTile")]
	public static void createGrassTile()
	{
		string path = EditorUtility.SaveFilePanelInProject ("Save Groundtile", "New Groundtile", "asset", "Save Groundtile", "Assets");
		if (path == "") 
		{
			return;
		}
		AssetDatabase.CreateAsset (ScriptableObject.CreateInstance<GroundTile> (), path);

	}

	#endif

}
