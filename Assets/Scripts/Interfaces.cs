using System.Collections;

public interface ICarnivore {
	void EatMeat();
}

public interface IHerbivore {
	void EatLeaves();
}

public interface ICanTrick {
	void PerformTrick();
	IEnumerator DoTrick();
}
