package worderope;

import worderope.WearingObjects.UnderwearType;

public class Socks extends WearingObjects{

	private UnderwearType underwear;
	public Socks(String material, String mark, int quantyty,UnderwearType underwear) {
		super(material, mark, Type.UNDERWEAR,quantyty);
	
		this.underwear = underwear;
	}
	@Override
	public int compareTo(WearingObjects wo) {
		Socks an = (Socks)wo;
		return this.material.compareTo(an.material); 
	}
	@Override
	public Wearable getWearable() {
		return this.underwear;
	}
	
	
	
	

}
