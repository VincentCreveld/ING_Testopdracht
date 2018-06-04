﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Tiger : Carnivore, ICanTrick {

        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "rraaarww";
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
