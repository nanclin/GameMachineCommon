using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameMacine {
    
    public class GameMachine : MonoBehaviour {

        public void LoadGame(string sceneName) {
            SceneManager.LoadScene(sceneName);
        }
    }

}