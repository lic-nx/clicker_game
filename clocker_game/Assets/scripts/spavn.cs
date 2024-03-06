using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spavn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spavn_point;
    public void create_evel()
    {
        Instantiate(enemyPrefab, spavn_point.position, Quaternion.identity);   
    }
}
