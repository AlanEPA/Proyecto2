using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassResouces : MonoBehaviour
{
    [SerializeField] private float resource;
    [SerializeField] private float resourceMax;
    [SerializeField] private float resourceSpeed;

    [SerializeField] private bool generateResource = false;


    // Start is called before the first frame update
    void Start()
    {
        resource = Mathf.Clamp(resource, 0, resourceMax);
    }

    private void Update()
    {
        if (generateResource)
        {
            GenerateResource();
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                resource = 0;
                generateResource = true;
            }
        }

    }

    public void GenerateResource()
    {
        if (resource < resourceMax)
        {        
            resource += Time.deltaTime * resourceSpeed;
        }
        else
        {
            generateResource = false;
        }
        Debug.Log(Mathf.Round(resource));
    }


}
