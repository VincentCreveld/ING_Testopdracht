using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo {
	public class Herbivore : Animal, IHerbivore {
		[SerializeField]
		private string herbivoreEatText = "";

		public void EatLeaves() {
			Balloon.SetActive(true);
			text.text = herbivoreEatText;
		}
	}
}
