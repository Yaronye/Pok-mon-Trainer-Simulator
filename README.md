Answer the following questions based on the code you’ve written and tested:

    F: When you create a Pokémon and try to access its fields directly – does it work? Why or why not?
    this works because the fields are public
    
    F: If you later want to add a new property that applies to all Electric-type Pokémon, where should you place it to avoid repetition?
    in the ElectricPokemon subclass.
    
    F: If instead the new property should apply to all Pokémon, where would be the correct place to define it?
    In the Pokemon class
    
    F: What happens if you try to add a Charmander to a list that only allows WaterPokemon?
      An error will be thrown.
    
    F: You want to store different types of Pokémon – Charmander, Squirtle, and Pikachu – in the same list. What type should the list have for that to work?
    A pokemon list
    
    F: When you loop through the list and call Attack(), what ensures that the correct attack behavior is executed for each Pokémon?
      
    
    F: If you create a method that only exists on Pikachu, why can’t you call it directly when it’s stored in a List<Pokemon>? How could you still access it?
      because the method doesn't exist for all Pokemon, only the pikachu pokemon. we can access it by writing pikachu.method drectly, or saving the stored pikachu from the list in a var, and then calling it. 
