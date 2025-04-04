using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetPlatform : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        GameController.MovePlatformToTop(gameObject);
    }
}
