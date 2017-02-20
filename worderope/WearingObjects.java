package worderope;


public abstract class WearingObjects implements Comparable<WearingObjects>{
	
	interface Wearable{};
	
	enum Type{UNDERWEAR, PANTS, CLOTHES};
	enum PantsType implements Wearable{ANCUNG,JEANS,PANTS};
	enum UnderwearType implements Wearable{BOKSERKI,SOCKS,POTNIK};
	enum ClothesType implements Wearable{TENISKI,RIZI,PULOVERI};
	
	protected String material;
	protected String mark;
	private Type type;
	protected int quantyty;
	
	
	public WearingObjects(String material, String mark,Type type,int quantyty) {
		this.material = material;
		this.mark = mark;
		this.type = type;
		this.quantyty = quantyty;
	}

	public  Type getType(){		
		return this.type;
	}
	
	@Override
	public String toString() {
		return this.material+"---" +this.mark+"----"+this.quantyty;
	}

	public abstract Wearable getWearable();
	

}
