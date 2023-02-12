using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject _doorClosed;
    [SerializeField] private GameObject _doorOpened;

    [SerializeField] private bool _isOpen = false;

    private void OnValidate()
    {
        if (_isOpen == true)
        {
            Open();
        }

        else
        {
            Close();
        }
    }

    private void Close()
    {
        _doorClosed.SetActive(true); // Closed Door (show).
        _doorOpened.SetActive(false); // Open Door (hide).
    }

    private void Open()
    {
        _doorOpened.SetActive(true); // Open Door (show).
        _doorClosed.SetActive(false); // Closed Door (hide).
    }
}
