using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScript : MonoBehaviour
{

    [SerializeField] private GameObject trilhas;

    // Start is called before the first frame update
    void Start()
    {
        trilhas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
