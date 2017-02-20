package worderope;

import worderope.WearingObjects.Wearable;

public class Rizi extends WearingObjects{
	
	private ClothesType clothes;
	
	public Rizi(String material, String mark, int quantyty,ClothesType clothes) {
		super(material, mark, Type.CLOTHES,quantyty);
	
		this.clothes = clothes;
	}

	@Override
	public int compareTo(WearingObjects wo) {
		Rizi an = (Rizi)wo;
		return this.material.compareTo(an.material); 
	}
	@Override
	public Wearable getWearable() {
		return this.clothes;
	}

}