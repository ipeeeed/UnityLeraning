using UnityEngine;

namespace Polimorfo {
    public class OrcCharacter : MyCharacter {
        void Start() {
            say();
        }

        public override void say()
        {
            Debug.Log("Olá humanos!");
        }
    }
}