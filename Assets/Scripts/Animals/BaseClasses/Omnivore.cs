using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo {
	public class Omnivore : Animal, ICarnivore, IHerbivore {
		[SerializeField]
		private string herbivoreEatText = "";
		[SerializeField]
		private string carnivoreEatText = "";

		public void EatLeaves() {
			Balloon.SetActive(true);
			text.text = herbivoreEatText;
		}

		public void EatMeat() {
			Balloon.SetActive(true);
			text.text = carnivoreEatText;
		}
	}
}
