package worderope;

import worderope.WearingObjects.Wearable;


public class Potnici extends WearingObjects{

	private UnderwearType underwear;
	
	public Potnici(String material, String mark, int quantyty,UnderwearType underwear) {
		super(material, mark, Type.UNDERWEAR,quantyty);
	
		this.underwear = underwear;
	}
	@Override
	public int compareTo(WearingObjects wo) {
		Potnici an = (Potnici)wo;
		return this.material.compareTo(an.material); 
	}
	@Override
	public Wearable getWearable() {
		return this.underwear;
	}


}
