package worderope;

import worderope.WearingObjects.ClothesType;
import worderope.WearingObjects.PantsType;
import worderope.WearingObjects.UnderwearType;

public class Demo {
	public static void main(String[] args) {
		Garderob garderob = new Garderob();
		
		Bokserki bokserki = new Bokserki("Koprina", "Gucci", 5,UnderwearType.BOKSERKI);
		Ancung ancung = new Ancung("Pamuk", "Addidas", 3,PantsType.ANCUNG);
		Ancung ancung1 = new Ancung("Pamuk", "Nike", 1,PantsType.ANCUNG);
		Ancung ancung2 = new Ancung("Pamuk", "Puma", 2,PantsType.ANCUNG);
		Jeans jeans = new Jeans("dunki", "Diesel", 4,PantsType.JEANS);
		Jeans jeans1 = new Jeans("dunki", "ADiesel", 1,PantsType.JEANS);
		Pantaloni pants = new Pantaloni("Pamuk", "Andrews", 7,PantsType.PANTS);
		Potnici potnik = new Potnici("Pamuk", "BG", 10,UnderwearType.POTNIK);
		Pylover pulover = new Pylover("Vulna", "NewYork", 4,ClothesType.PULOVERI);
		Rizi rizi = new Rizi("Saten","Gabbana",5,ClothesType.RIZI);
		Socks socks = new Socks("Bambuk", "China", 12,UnderwearType.SOCKS);
		Teniski teniski = new Teniski("izkustven", "Nike", 10,ClothesType.TENISKI);
		
		garderob.addClothes(bokserki);
		garderob.addClothes(ancung);
		garderob.addClothes(jeans);
		garderob.addClothes(jeans1);
		garderob.addClothes(pants);
		garderob.addClothes(potnik);
		garderob.addClothes(pulover);
		garderob.addClothes(rizi);
		garderob.addClothes(socks);
		garderob.addClothes(teniski);
		garderob.addClothes(ancung1);
		garderob.addClothes(ancung2);
		garderob.printClothes();
		
		
	}
	

}
