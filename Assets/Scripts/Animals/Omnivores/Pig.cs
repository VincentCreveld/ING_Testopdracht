using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : Omnivore, ICanTrick {

        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "oink oink";
        }

        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        public IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
