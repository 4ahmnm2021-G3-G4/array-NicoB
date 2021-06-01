using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrays : MonoBehaviour
{
    string[] array1 = new string[4];
    float[] array2 = new float[4] { 1f, 2f, 3f, 4f };
    int[] array3 = new int[4] { 1, 2, 3, 4 };
    GameObject[] array4 = new GameObject[4];

    /* Aufgabe: 
     * Durchlaufen ausgeben der Werte
     * Länge des Array ausgeben als Debug
     * 2 Werte direkt ändern
     * GameObjects Images anlegen, Tag vergeben, Zuweisen und Farbe ändern 
     */
    // Start is called before the first frame update
    void Start()
    {
        foreach (float array2f in array2)
        {
            Debug.Log("Array2: " + array2f);
        }
        Debug.Log("Array1: " + array1.Length);
        array3[1] = 2;
        array3[2] = 1;
        array4 = GameObject.FindGameObjectsWithTag("RedImage");
        array4[2].GetComponent<Image>().color = Color.red;
    }
}
