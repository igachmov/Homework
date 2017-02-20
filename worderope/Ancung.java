package worderope;

public class Ancung extends WearingObjects{
	
	
	
	private PantsType pants;
	
	
	public Ancung(String material, String mark, int quantyty,PantsType pants) {
		super(material, mark, Type.PANTS,quantyty);
	
		this.pants = pants;
	}

	@Override
	public int compareTo(WearingObjects wo) {
		Ancung other = (Ancung)wo;
		return this.mark.compareTo(other.mark); 
	}

	@Override
	public PantsType getWearable() {
		return pants;
	}

}
