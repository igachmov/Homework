package worderope;

import worderope.WearingObjects.Wearable;


public class Bokserki extends WearingObjects{

	private UnderwearType underwear;
	
	
	public Bokserki(String material, String mark, int quantyty,UnderwearType underwear) {
		super(material, mark, Type.UNDERWEAR,quantyty);
	
		this.underwear = underwear;
	}
	@Override
	public int compareTo(WearingObjects wo) {
		Bokserki an = (Bokserki)wo;
		return this.material.compareTo(an.material); 
	}

	@Override
	public Wearable getWearable() {
		return this.underwear;
	}


}
