string[] inventory = { 
    "B123","C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
foreach (string indicator in inventory) {
    if(indicator.StartsWith("B")){
        Console.WriteLine(indicator);
    }

}