using UnityEngine;

public class POO : MonoBehaviour
{
    public class Personagem {
        public float vida;
        public float poder;
        public float exp;

        public void aumentarVida() {

        }

        public Personagem(float exp) {
            this.exp = exp;
        }
    }

    Personagem p1 = new Personagem(50f);
}
