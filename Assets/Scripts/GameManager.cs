using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class GameManager : MonoBehaviour
    {
		public InputField inputField;

        [SerializeField]
        private GameObject[] zooAnimalPrefabs;
		private List<Animal> zooAnimals = new List<Animal>();
		private string message = "";

        private void Start()
        {
			SpawnAnimals();
        }

		// Instantiates all animal prefabs placed in the zooAnimalPrefabs array.
		private void SpawnAnimals() {
			foreach(var GO in zooAnimalPrefabs) {
				zooAnimals.Add(Instantiate(GO, transform).GetComponent<Animal>());
			}
		}

		// Checks if entered string is not empty. Then proceeds to tell all animals to say hello.
		// If a name is entered, only tell the relevant animal to say hello.
		public void SayHello() {
			if(message.Length < 1 || message == "") {
				foreach(var animal in zooAnimals) {
					animal.SayHello();
				}
			}
			else {
				foreach(var animal in zooAnimals) {
					if(animal.animalName == message)
						animal.SayHello();
				}
			}
		}

		// Calls all ICarnivore interfaces to eat some meat.
		public void GiveMeat() {
			foreach(var animal in zooAnimals) {
				if(animal.gameObject.GetComponent<ICarnivore>() != null)
					animal.gameObject.GetComponent<ICarnivore>().EatMeat();
			}
		}

		// Calls all IHerbivore interfaces to eat some meat.
		public void GiveLeaves() {
			foreach(var animal in zooAnimals) {
				if(animal.gameObject.GetComponent<IHerbivore>() != null)
					animal.gameObject.GetComponent<IHerbivore>().EatLeaves();
			}
		}

		// Calls all ICanTrick interfaces to do their tricks.
		public void DoTricks() {
			foreach(var animal in zooAnimals) {
				if(animal.gameObject.GetComponent<ICanTrick>() != null)
					animal.gameObject.GetComponent<ICanTrick>().PerformTrick();
			}
		}

		// Gets called form the UI elements when "Hello" is pressed or the animal name is entered.
		public void SetMessage() {
			message = inputField.text;
		}
	}
}
