using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType
{
    Forest,
    Grass,
    Water,
    Path
}

public class TileInitilizer : MonoBehaviour
{

    [SerializeField] private float frequency;
    [SerializeField] private Material[] typeMaterial;
    [SerializeField] private GameObject[] typeDecoration;
    [SerializeField] private new MeshRenderer renderer;

    private TileType type;

    public void InitializeTile()
    {
        GenerateType();
    }

    private void GenerateType()
    {
        float xPos = transform.position.x;
        float zPos = transform.position.z;

        float typeValue = Mathf.PerlinNoise(xPos * frequency, zPos * frequency) * 4;

        int currentType = (int)Mathf.Clamp(typeValue, 0, 3);
        type = (TileType)currentType;
        renderer.material = typeMaterial[currentType];

        Instantiate(typeDecoration[currentType], transform.position + typeDecoration[currentType].transform.position, Quaternion.Euler(0, UnityEngine.Random.Range(-180.0f, 180.0f), 0), transform).SetActive(true);

    }
}
