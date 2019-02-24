using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameMachine {
    
    public class GameBase : MonoBehaviour {

        public void ExitGame() {
            SceneManager.LoadScene("Main");
        }
    }

}