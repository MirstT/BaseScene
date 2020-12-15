using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ins : MonoBehaviour
{
    public Transform prefab;
    public void Awake()
    {
        int i = 0;
        while (i < 6)
        {
            Instantiate(prefab, new Vector3(i * 2-2, 2, 2), Quaternion.identity);
            i++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
