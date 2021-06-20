using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBrush : MonoBehaviour
{

    [SerializeField] private TileInitilizer tilePrototype;
    [SerializeField] private LayerMask tileLayer;
    [SerializeField] private Bounce bounce;

    void Start()
    {
        CreateTile();
    }


    public void CreateTile()
    {
        if (!RaycastTile())
        {
            TileInitilizer createdTile = Instantiate(tilePrototype, transform.position + Vector3.down * 0.5f, Quaternion.identity);
            createdTile.InitializeTile();
            createdTile.gameObject.SetActive(true);
            //bounce.StartBouncing();
        }
    }

    private bool RaycastTile()
    {
        return Physics.Raycast(transform.position, Vector2.down, 10, tileLayer);
    }
}
