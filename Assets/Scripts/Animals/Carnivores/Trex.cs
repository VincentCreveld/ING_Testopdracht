using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo {
	class Trex : Carnivore {

		public override void SayHello() {
			Balloon.SetActive(true);
			text.text = "RAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAWR";
		}
	}
}
