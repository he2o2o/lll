using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class save : MonoBehaviour
{
    const string DLL_NAME = "Project2";
    [DllImport(DLL_NAME)]
    private static extern int SimpleFunction();

    [DllImport(DLL_NAME)]
    private static extern int get(float x, float y, float z);

    [DllImport(DLL_NAME)]
    private static extern void load();

    [DllImport(DLL_NAME)]
    private static extern float lx();

    [DllImport(DLL_NAME)]
    private static extern float ly();

    [DllImport(DLL_NAME)]
    private static extern float lz();

   


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log(SimpleFunction());
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            get(transform.position.x, transform.position.y, transform.position.z);
      
            Debug.Log(transform.position.x);
            Debug.Log(transform.position.y);
            Debug.Log(transform.position.x);
          
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            load();
            float nx = lx();
            float ny = ly();
            float nz = lz();
            Vector3 temp= new Vector3(nx, ny, nz);
            
            transform.position = Vector3.MoveTowards(transform.position, temp, 1000 * Time.deltaTime);

            Debug.Log(lx());
            Debug.Log(ly());
            Debug.Log(lz());
        }
    }
}

