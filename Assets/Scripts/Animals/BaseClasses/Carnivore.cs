using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo {
	public class Carnivore : Animal, ICarnivore {
		[SerializeField]
		private string carnivoreEatText = "";

		public void EatMeat() {
			Balloon.SetActive(true);
			text.text = carnivoreEatText;
		}
	}
}
