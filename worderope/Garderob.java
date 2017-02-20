package worderope;

import java.util.HashMap;
import java.util.Map.Entry;
import java.util.TreeSet;

import worderope.WearingObjects.Type;
import worderope.WearingObjects.Wearable;
public class Garderob {

	HashMap<Type,HashMap<Wearable, TreeSet<WearingObjects>>> garderob;
	
	public Garderob(){
		garderob = new HashMap();
		garderob.put(Type.UNDERWEAR, new HashMap<Wearable, TreeSet<WearingObjects>>());
		garderob.put(Type.CLOTHES, new HashMap<Wearable, TreeSet<WearingObjects>>());
		garderob.put(Type.PANTS, new HashMap<Wearable, TreeSet<WearingObjects>>());		
	}
	
	
	public void addClothes(WearingObjects obj){
		Type type = obj.getType();
		Wearable wearable = obj.getWearable();
		if(!garderob.containsKey(type)){
			garderob.put(type, new HashMap<Wearable, TreeSet<WearingObjects>>());			
		}
		if(!garderob.get(type).containsKey(wearable)){
			garderob.get(type).put(wearable, new TreeSet<WearingObjects>());
		}
		garderob.get(type).get(wearable).add(obj);
	}
	
	public void printClothes(){
		for(Entry<Type,HashMap<Wearable, TreeSet<WearingObjects>>> e: garderob.entrySet()){
			System.out.println("------------"+e.getKey()+"------------");
			for(Entry<Wearable, TreeSet<WearingObjects>> e1: e.getValue().entrySet()){
				System.out.println("     ------------"+e1.getKey()+"------------");
				for(WearingObjects wo : e1.getValue() ){
					System.out.println("        ------------"+wo+"------------");
				}
			}
		}
		
		
		
	}
	
}
