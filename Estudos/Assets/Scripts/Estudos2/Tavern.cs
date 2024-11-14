using UnityEngine;

namespace Polimorfo {
    public class Tavern : MonoBehaviour {
        public MyCharacter[] chars;

        void Start() {
            chars = new MyCharacter[2];
            chars[0] = new ManCharacter();
            chars[1] = new OrcCharacter();

            EnterTavern();
        }

        private void EnterTavern()
        {
            foreach (MyCharacter c in chars)
            {
                c.say();
            }
        }
    }
}