using UnityEngine;

namespace Polimorfo {
    public class MyCharacter : MonoBehaviour {
        public string charName;
        public int health;
        public int strengt;
        public float speed;

        public virtual void say() {
            Debug.Log("Olá!");
        }
    }
}