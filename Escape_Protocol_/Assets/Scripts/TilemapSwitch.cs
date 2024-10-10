using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapSwitch : MonoBehaviour
{
    public TileBase tile1;
    public TileBase tile2;
    public TileBase tile3;
    public TileBase tile4;
    public TileBase tile5;
    public TileBase tile6;        
    public TileBase tile7;
    public TileBase tile8;
    public TileBase tile9;
    public TileBase tile10;
    public TileBase tile11;
    public TileBase tile12;
    public TileBase tile13;
    public TileBase tile14;
    public TileBase tile15;
    public TileBase tile16;
    public TileBase tile17;
    public TileBase tile18;
    public TileBase tile19;
    public TileBase tile20;
    public TileBase tile21;
    public TileBase tile22;
    public TileBase tile23;
    public TileBase tile24;
    public TileBase tile25;
    public TileBase tile26;

    void Start()
    {
        Tilemap tilemap = GetComponent<Tilemap>();

        tilemap.SwapTile(tile1, tile2);
        tilemap.SwapTile(tile3, tile4);
        tilemap.SwapTile(tile5, tile6);
        tilemap.SwapTile(tile7, tile8);
        tilemap.SwapTile(tile9, tile10);
        tilemap.SwapTile(tile11, tile12);
        tilemap.SwapTile(tile13, tile14);
        tilemap.SwapTile(tile15, tile16);
        tilemap.SwapTile(tile17, tile18);
        tilemap.SwapTile(tile19, tile20);
        tilemap.SwapTile(tile21, tile22);
        tilemap.SwapTile(tile23, tile24);
        tilemap.SwapTile(tile25, tile26);
    }
}