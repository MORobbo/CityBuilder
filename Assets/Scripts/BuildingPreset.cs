using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CreateAssetMenu(fileName = "Build Preset", menuName = "New Building Preset")]
public class BuildingPreset : ScriptableObject
{
    public string displayName;
    public int cost;
    public int costPerTurn;
    public GameObject prefab;

    public int population;
    public int jobs;
    public int food;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
