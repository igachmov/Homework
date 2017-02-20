package worderope;

import worderope.WearingObjects.ClothesType;

public class Teniski extends WearingObjects{
	
	private ClothesType clothes;
	public Teniski(String material, String mark, int quantyty,ClothesType clothes) {
		super(material, mark, Type.CLOTHES,quantyty);

		this.clothes = clothes;
	}
	@Override
	public int compareTo(WearingObjects wo) {
		Teniski an = (Teniski)wo;
		return this.material.compareTo(an.material); 
	}
	@Override
	public Wearable getWearable() {
		return this.clothes;
	}
	
}
