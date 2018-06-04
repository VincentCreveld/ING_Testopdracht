using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo: Herbivore {

        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "splash";
        }
    }
    
}
