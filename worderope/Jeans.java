package worderope;


public class Jeans extends WearingObjects{
	

	private PantsType pants;
	
	public Jeans(String material, String mark, int quantyty,PantsType pants) {
		super(material, mark, Type.PANTS,quantyty);
		
		this.pants = pants;
	}
	@Override
	public int compareTo(WearingObjects wo) {
		Jeans an = (Jeans)wo;
		return  this.mark.compareTo(an.mark);
	}
	@Override
	public PantsType getWearable() {
		return pants;
	}
}
