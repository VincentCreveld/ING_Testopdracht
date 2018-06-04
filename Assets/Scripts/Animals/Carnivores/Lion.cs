using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Lion : Carnivore {

        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "roooaoaaaaar";
        }
    }
}
