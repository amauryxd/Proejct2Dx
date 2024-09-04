using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class DrawBPM : MonoBehaviour
{
public float pulsosPorMinuto = 75f; // Ejemplo de valor
public int cantidadRayas = 12; // Número de rayas a dibujar
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnDrawGizmos()
{
    // Configurar el color del Gizmo
    Gizmos.color = Color.red;

    // Calcular la separación entre cada raya
    float separacion = pulsosPorMinuto / cantidadRayas;

    // Dibujar cada raya
    for (int i = 0; i < cantidadRayas; i++)
    {
        // Calcular la posición de cada raya
        Vector3 inicio = transform.position + new Vector3(separacion * i, 0, 0);
        Vector3 fin = inicio + new Vector3(0, pulsosPorMinuto / 10f, 0); // Ajusta el divisor según sea necesario

        // Dibujar la raya
        Gizmos.DrawLine(inicio, fin);
    }
}
}


