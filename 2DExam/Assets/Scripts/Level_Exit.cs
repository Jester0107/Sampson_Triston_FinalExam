using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Exit : MonoBehaviour


{
    public void SceneManager()
 {
  SceneManager(SceneManager.LoadScene.BuildIndex + 1);
  LoadScene ();
 }
}
