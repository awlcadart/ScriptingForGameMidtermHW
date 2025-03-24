using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class NewTarget : MonoBehaviour
{
    public List<GameObject> targets;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            foreach (GameObject t in targets)
            {
                Debug.Log (t.name);
                if (t.gameObject.activeSelf == false)
                {
                    t.gameObject.SetActive(true);
                }
            }
        }
            
    }
}
