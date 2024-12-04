using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cs_reiniciar : MonoBehaviour
{
    private void Update() {
    if (Input.GetKeyDown(KeyCode.R)) {
        SceneManager.LoadSceneAsync(
            SceneManager.GetActiveScene().buildIndex);
    }
}
}
