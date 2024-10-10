using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PieceController : MonoBehaviour
{
    [SerializeField] private Transform cubeTransform; //NO MODIFICAR

    private float _scaleSelected = 1.1f; //NO MODIFICAR
    private float _scaleUnselected = 1.0f; //NO MODIFICAR

    private Material outlineMaterial; //NO MODIFICAR

    public UnityEvent OnStartAnimation; //NO MODIFICAR
    public UnityEvent OnFinishAnimation; //NO MODIFICAR

    private void Awake()
    {
        outlineMaterial = GetComponent<MeshRenderer>().materials[1]; //NO MODIFICAR

        Unselect(); //NO MODIFICAR
    }

    public void Select()
    {
        outlineMaterial.SetFloat("_Scale", _scaleSelected); //NO MODIFICAR
    }

    public void Unselect()
    {
        outlineMaterial.SetFloat("_Scale", _scaleUnselected); //NO MODIFICAR
    }

    //NO MODIFICAR
    public void RotateLeft()
    {
        StartCoroutine(RotatePiece(90f));
    }

    //NO MODIFICAR
    public void RotateRight()
    {
        StartCoroutine(RotatePiece(-90f));
    }

    IEnumerator RotatePiece(float rotation)
    {
        OnStartAnimation?.Invoke(); //NO MODIFICAR

        float startAngle = cubeTransform.eulerAngles.z;
        float currentNextAngle = 0f;

        float targetPosition = cubeTransform.eulerAngles.z + rotation;

        StartCoroutine(TranslateAnimation(0f, 0f));

        yield return new WaitForSeconds(0.1f); //NO MODIFICAR

        float currentAngle = 0f; ;

        float time = 0;

        while (time < 1f) //NO MODIFICAR
        {
            time += Time.deltaTime * 5f; //NO MODIFICAR

            currentAngle = Mathf.Lerp(startAngle, currentNextAngle, time); //NO MODIFICAR
            cubeTransform.rotation = Quaternion.Euler(0, 0, currentAngle);

            yield return null; //NO MODIFICAR
        }
        cubeTransform.rotation = Quaternion.Euler(0, 0, targetPosition);
        StartCoroutine(TranslateAnimation(0f, 0f));

        yield return new WaitForSeconds(0.1f); //NO MODIFICAR

        OnFinishAnimation?.Invoke(); //NO MODIFICAR
    }

    private IEnumerator TranslateAnimation(float startPosition, float targetPosition)
    {
        float time = 0f; //NO MODIFICAR

        float currentPosition = startPosition; //NO MODIFICAR

        while (time < 1f) //NO MODIFICAR
        {
            time += Time.deltaTime * 10f; //NO MODIFICAR

            currentPosition = Mathf.Lerp(startPosition, targetPosition, time); //NO MODIFICAR

            yield return null; //NO MODIFICAR
        }
    }
}
