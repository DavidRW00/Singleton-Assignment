using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public void InstantiateCaller(GameObject prefab)
    {
        Instantiate(prefab);
    }
}
