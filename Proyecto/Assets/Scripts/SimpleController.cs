using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    [SerializeField] private PieceController[] cubes; //NO MODIFICAR

    [SerializeField] int _currentPosition = 0; //NO MODIFICAR

    private bool _canAct = true; //NO MODIFICAR

    //012
    //345
    //678

    //NO MODIFICAR
    private void Start()
    {
        cubes[_currentPosition].Select();
    }

    public void PressUp()
    {
        if (!_canAct) return; //NO MODIFICAR
        print("Arriba");
        if (_currentPosition - 3 >= 0)
        {
            cubes[_currentPosition].Unselect(); //NO MODIFICAR
            _currentPosition -= 3;
            cubes[_currentPosition].Select(); //NO MODIFICAR
        }
        print(_currentPosition);
    }

    public void PressDown()
    {
        if (!_canAct) return; //NO MODIFICAR
        print("Abajo");
        if (_currentPosition + 3 < cubes.Length)
        {
            cubes[_currentPosition].Unselect(); //NO MODIFICAR
            _currentPosition += 3; 
            cubes[_currentPosition].Select(); //NO MODIFICAR
        }
        print(_currentPosition);
    }

    public void PressLeft()
    {
        if (!_canAct) return; //NO MODIFICAR
        print("izquierda");
        if (_currentPosition % 3 != 0)
        {
            cubes[_currentPosition].Unselect(); //NO MODIFICAR
            _currentPosition -= 1; 
            cubes[_currentPosition].Select(); //NO MODIFICAR
        }
        print(_currentPosition);
    }

    public void PressRight()
    {
        if (!_canAct) return; //NO MODIFICAR
        print("Derecha");
        if (_currentPosition % 3 != 2)
        {
            cubes[_currentPosition].Unselect(); //NO MODIFICAR
            _currentPosition += 1; 
            cubes[_currentPosition].Select(); //NO MODIFICAR
        }
        print(_currentPosition);
    }

    //NO MODIFICAR
    public void PressRotateLeft()
    {
        if (!_canAct) return;

        cubes[_currentPosition].RotateLeft();
    }

    //NO MODIFICAR
    public void PressRotateRight()
    {
        if (!_canAct) return;

        cubes[_currentPosition].RotateRight();
    }

    //NO MODIFICAR
    public void DisableAction()
    {
        _canAct = false;
    }

    //NO MODIFICAR
    public void AllowAction()
    {
        _canAct = true;
    }
}
