using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class anotherdrawlines : MonoBehaviour
{
    public int numberOfLines; // Número de líneas a dibujar
    public float distanceBetweenLines; // Distancia entre cada línea
    public Vector3 startPoint = Vector3.zero; // Punto de inicio de la primera línea
    public Vector3 direction = Vector3.right; // Dirección en la que se dibujarán las líneas
    public float lineLength; // Longitud de las líneas

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        for (int i = 0; i < numberOfLines; i++)
        {
            Vector3 offset = direction * distanceBetweenLines * i;
            Vector3 lineStart = startPoint + offset;
            Vector3 lineEnd = lineStart + Vector3.up * lineLength; // Ajusta la longitud de la línea aquí

            Gizmos.DrawLine(lineStart, lineEnd);
        }
    }
}
