package worderope;

public class Pylover extends WearingObjects{
	
	
	private ClothesType clothes;
	public Pylover(String material, String mark, int quantyty,ClothesType clothes) {
		super(material, mark, Type.CLOTHES,quantyty);

		this.clothes = clothes;
	}

	@Override
	public int compareTo(WearingObjects wo) {
		Pylover an = (Pylover)wo;
		return this.material.compareTo(an.material); 
	}

	@Override
	public Wearable getWearable() {
		return this.clothes;
	}
}
