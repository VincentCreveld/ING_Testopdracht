using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Zebra : Herbivore {
        
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "zebra zebra";
        }
    }
}
