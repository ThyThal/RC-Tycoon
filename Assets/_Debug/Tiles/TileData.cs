using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "Tile Data", menuName = "Tile Data")]
public class TileData : ScriptableObject
{
    [SerializeField] public bool _isWalkable = false;
    [SerializeField] public TileBase[] Tiles;
}
