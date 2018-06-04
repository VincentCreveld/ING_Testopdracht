using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo {
	class Turtle : Herbivore {

		public override void SayHello() {
			Balloon.SetActive(true);
			text.text = "h... e... l... l... o...";
		}
	}
}
