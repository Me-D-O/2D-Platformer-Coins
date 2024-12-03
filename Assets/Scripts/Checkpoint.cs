using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SpawnpointState
{
    Active, Inactive
}

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Color activeColor;
    [SerializeField] private Color inactiveColor;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private SpriteRenderer indicatorRenderer;

    private void Awake()
    {
        //indicatorRenderer.color = inActiveColor;
    }

    public Transform GetSpawnPoint()
    {
        return spawnPoint;
    }

    public void SetCheckpointState(bool isActive)
    {
        var color = isActive ? activeColor : inactiveColor;
        indicatorRenderer.color = color;

        // Ovo je isto
        /*
        if(isActive)
        {
            indicatorRenderer.color = Color.green;
        }
        else
        {
            indicatorRenderer.color = Color.yellow;
        }
        */
    }
}