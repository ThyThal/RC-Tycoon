using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapManager : MonoBehaviour
{
    [SerializeField] public Tilemap _tilemap;
    [SerializeField] private List<TileData> _tilesData;
    [SerializeField] private Dictionary<TileBase, TileData> _dataFromTiles;

    private void Awake()
    {
        _dataFromTiles = new Dictionary<TileBase, TileData>();

        foreach (TileData tileData in _tilesData)
        {
            foreach (var tile in tileData.Tiles)
            {
                _dataFromTiles.Add(tile, tileData);
            }
        }
    }

    private void Update()
    {
        // Check Left Click Input.
        if (Input.GetMouseButtonDown(0))
        {
            // Current Mouse Position in Game World.
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            // Current Mouse Position in Tilemap World.
            Vector3Int gridPosition = _tilemap.WorldToCell(mousePosition);

            // Gets Clicked Tile in Tilemap.
            TileBase clickedTile = _tilemap.GetTile(gridPosition);
            Debug.Log($"[Debug]: Clicked ({gridPosition}), returned ({clickedTile.name})");
        }
    }
}
