using UnityEngine;

namespace Polimorfo {
    class ManCharacter : MyCharacter {
        void Start() {
            say();
        }

        public override void say()
        {
            Debug.Log("Olá galerinha!");
        }
    }
}