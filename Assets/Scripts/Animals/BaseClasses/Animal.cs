using UnityEngine;
using UnityEngine.UI;

namespace Zoo {
	public class Animal : MonoBehaviour {
		public string animalName;

		[SerializeField]
		protected GameObject Balloon;
		[SerializeField]
		protected Text text;

		public virtual void SayHello() { }

	}
}
