using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour
{
    Matrix obj =  new Matrix();
    public int [,] Matrix_Array;
    int Column_number;
    int Row_number;
    // Start is called before the first frame update
    void Start()
    {
        obj.Initialize_Matrix(3,4);
        obj.Set_matrix();
        obj.Set_Digonal(4);
        obj.print_Matrix();
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
