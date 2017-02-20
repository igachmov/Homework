package worderope;


public class Pantaloni extends WearingObjects{
	
	
	private PantsType pants;
	
	public Pantaloni(String material, String mark, int quantyty,PantsType pants) {
		super(material, mark, Type.PANTS,quantyty);		
		this.pants = pants;
	}
	@Override
	public int compareTo(WearingObjects wo) {
		Pantaloni an = (Pantaloni)wo;
		return this.material.compareTo(an.material); 
	}
	@Override
	public PantsType getWearable() {
		return pants;
	}

}
