using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPatter : MonoBehaviour
{
    public GameObject meteor;

    private void Start()
    {
        Instantiate(meteor, transform.position, Quaternion.identity);
    }
}
