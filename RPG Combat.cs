int playerHP = 10;
int enemyHP = 10;
Random dice = new Random();

do
{   
    int attack = dice.Next(1,11);
    enemyHP -= attack;
    Console.WriteLine($"The hero attacked the enemy monster by {attack}! The enemy has {enemyHP}HP left!");

    if ( enemyHP <= 0) continue;

    attack = dice.Next(1,11);
    playerHP -= attack;
    Console.WriteLine($"The enemy monster attacked the player by {attack}! The player has {playerHP}HP left!");
} while (playerHP > 0 && enemyHP > 0);

Console.WriteLine(playerHP > enemyHP ? "Player wins!" : "Enemy monster wins!");