public class TimeMap {
    Dictionary<string, Dictionary<int, string>> timeMap;
    
    public TimeMap() {
        timeMap = new Dictionary<string, Dictionary<int, string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!timeMap.ContainsKey(key)) {
            timeMap[key] = new Dictionary<int,string>();
        }
        timeMap[key][timestamp] = value;
    }
    
    public string Get(string key, int timestamp) {
        if(!timeMap.ContainsKey(key)) {
            return "";
        }
        
        for(int currentTime = timestamp; currentTime >= 1; currentTime--) {
            if(timeMap[key].ContainsKey(currentTime)) {
                return timeMap[key][currentTime];
            }
        }
        
        return "";
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */