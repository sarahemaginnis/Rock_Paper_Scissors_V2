using Rock_Paper_Scissors_V2;

Game game = new Game();
game.playerPoints = 0;
game.computerPoints = 0;

Player player = new Player();
Computer computer = new Computer();

while (game.playerPoints < 3 && game.computerPoints < 3)
{
    Console.WriteLine(@$"---------------------
| Player: {game.playerPoints}   |   Computer: {game.computerPoints} |
---------------------
What would you like to throw?
1) Rock
2) Paper
3) Scissors");
    player.PlayerChoiceDetermination();
    //need save playerChoiceDetermination as a variable
    Console.WriteLine(game.WinnerDetermination());
    Console.ReadKey();
    Console.Clear();
}
