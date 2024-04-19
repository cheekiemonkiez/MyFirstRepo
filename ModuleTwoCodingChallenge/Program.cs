using ModuleTwoCodingChallenge;

Polygon polygon = new Polygon(3);
Square square = new Square(4.5f);
Pentagon pentagon = new Pentagon(5);
Polygon hexagon = new Polygon(6);
Polygon trapazoid = new Polygon(4);

// Create a new player with one life and add points to the player's score
Player player = new Player("Frankenstein", 1);
player.AddPoints(100);

// Dispaly the player's score
Console.WriteLine("Welcome to the game! Your score is: " + player.GetScore() +
    " You have " + player.GetLivesLeft() + "lives left!");

// Kill the player
player.kill();

// Let the player know they were killed
Console.WriteLine("An or attacks, sorry, you were killed. You have " + player.GetLivesLeft() 
    + "lives left");