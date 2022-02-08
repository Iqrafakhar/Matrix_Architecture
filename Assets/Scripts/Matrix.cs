using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix
{
    public int [,] Matrix_Array;
    //static int Column_number;
    //static int Row_number;
    //List<List<float>> mattrix;
    // Start is called before the first frame update
    public Matrix()
    {
        /*for(int i = 0; i < numOfrow ; i++)
        {
            for(int  j = 0; i < numOfcol; j++)
            {
                mattrix[i][j] = 0;
            }
        }*/
    }

    public void Initialize_Matrix(int Col,int row)
        {
            Matrix_Array = new int[row, Col];
        }

    public void Set_matrix()
        {
            for (int i = 0; i < Matrix_Array.GetLength(0); i++)
            {
                for(int j = 0; j < Matrix_Array.GetLength(1); j++)
                {
                    Matrix_Array[i, j] = 0;
                }
            }
        }

    public void print_Matrix()
        {
            for (int i = 0; i < Matrix_Array.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix_Array.GetLength(1); j++)
                {
                    Debug.Log(Matrix_Array[i, j]);
                }
            }
        }


    /*public void set_rows_column()
        {
            Debug.Log("Enter the Number of Rows");
            Row_number = Convert.ToInt16(Console.ReadLine());
            Debug.Log("Enter the Number of Column");
            Column_number = Convert.ToInt16(Console.ReadLine());
        }*/
       
    public void SetElement(int value, int row_num, int col_num)
        {
            Matrix_Array[row_num,col_num] = value;
        }
    public int getElelment(int row, int col)
        {
            return Matrix_Array[row,col];
        }
        
    public void add_Matrix(int[,] matrix1, int[,] matrix2)
        {
            if(matrix2.GetLength(0) == Matrix_Array.GetLength(0) && matrix2.GetLength(1) == Matrix_Array.GetLength(1) && matrix1.GetLength(0) == Matrix_Array.GetLength(0) && matrix1.GetLength(1) == Matrix_Array.GetLength(1))
            {
                for(int i = 0; i < Matrix_Array.GetLength(0); i++)
                {
                    for(int j = 0; j < Matrix_Array.GetLength(1); j++)
                    {
                        matrix1[i,j]= matrix2[i,j]+Matrix_Array[i,j];
                    }
                }
            }
        }
        
    public void subtract_Matrix(int[,] matrix1, int[,] matrix2)
        {
             if(matrix2.GetLength(0) == Matrix_Array.GetLength(0) && matrix2.GetLength(1) == Matrix_Array.GetLength(1) && matrix1.GetLength(0) == Matrix_Array.GetLength(0) && matrix1.GetLength(1) == Matrix_Array.GetLength(1))
            {
                for(int i = 0; i < Matrix_Array.GetLength(0); i++)
                {
                    for(int j = 0; j < Matrix_Array.GetLength(1); j++)
                    {
                        matrix1[i,j]= matrix2[i,j] - Matrix_Array[i,j];
                    }
                }
            }
        }
        
    public void Set_Matrix(int num)
        {
           for (int i = 0; i < Matrix_Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix_Array.GetLength(1); j++)
                    {
                        Matrix_Array[i,j] = num;
                    }
                }
        }
        
    public void Set_Row(int row_number, int num)
        {
                    for (int j = 0; j < Matrix_Array.GetLength(1); j++)
                    {
                        Matrix_Array[row_number,j] = num;
                    }
                
        }
        
    public void Set_Col(int Col_number, int num)
        {
                    for (int i = 0; i < Matrix_Array.GetLength(0); i++)
                    {
                        Matrix_Array[i,Col_number] = num;
                    }
        }
        
  /*public float Get_Row(int row_number)
        {
            int[] row = new int[Matrix_Array.GetLength(1)]; 
            for(int i = 0; i < row.GetLength(0); i++)
            {
                for(int j = 0; j < Matrix_Array.GetLength(1); j++)
                {

                }
            }
        }*/
        
    public void Set_Digonal(int num)
    {
        for (int i = 0; i < Matrix_Array.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix_Array.GetLength(1); j++)
                    {
                        if(i == j)
                            {
                                Matrix_Array[i,j] = num;
                            }
                    }
            }
    }

    public void set_InverseDigonal(int num)
    {
        for (int i = 0; i < Matrix_Array.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix_Array.GetLength(1); j++)
                    {
                        if(i == j)
                            {
                                Matrix_Array[i,j] = 1/Matrix_Array[i,j];
                            }
                    }
            }
    }

    public bool is_Row_Same(int row_num)
    {
        bool result = true;
        for (int j = 0; j < (Matrix_Array.GetLength(1) -1); j++)
        {
            if(Matrix_Array[row_num,j] == Matrix_Array[row_num,j++])
            {
                result  = true;
            }
            else{
                result  = false;
                break;
            }
        }
        return result;
            
    }
    
    public bool is_col_Same(int col_num)
    {
        bool result = true;
        for (int j = 0; j < (Matrix_Array.GetLength(0) - 1); j++)
        {
            if(Matrix_Array[j,col_num] == Matrix_Array[j++, col_num])
            {
                result  = true;
            }
            else{
                result  = false;
                break;
            }
        }
        return result;
            
    }

    public bool is_Digonal_same(int num)
    {
        bool result =true;
        for (int i = 0; i < Matrix_Array.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix_Array.GetLength(1); j++)
                    {
                        if(i == j)
                            {
                                if(Matrix_Array[i,j] == Matrix_Array[i+1,j+1])
                                {
                                    result = true;
                                }
                                else
                                {
                                    result = false;
                                }
                            }
                    }
            }
        return result;
    }


    public void multiply_Matrix(int[,] matrix2)
        {
            if (Matrix_Array.GetLength(1) == matrix2.GetLength(0))
            {
                for (int i = 0; i < Matrix_Array.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        int temp = 0;
                        for (int k = 0; k < Matrix_Array.GetLength(1); k++)
                        {
                            temp += Matrix_Array[i,k] * matrix2[j,k];
                        }
                        Matrix_Array[i,j] = temp;
                    }
                }
            }
            else
            {
                Debug.Log("Column of first matrix is not equal to 2nd matrix so can't multiply");
            }
        }
}
