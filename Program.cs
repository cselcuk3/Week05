// ===== PART A =====
// A1: 5
// A2: Hurt
// A3: 4
// A4: 14


// ===== B1 =====
{
    int baseDamage = 40;
    int armor = 15;
    int level = 4;

    int damage = baseDamage - armor;

    if (level >= 5)
    {
        damage = damage + 10;
    }

    if (damage < 1)
    {
        damage = 1;
    }

    string label = "";
    if (damage >= 30)
    {
        label = "Strong hit";
    }
    else if (damage >= 10)
    {
        label = "Normal hit";
    }
    else
    {
        label = "Weak hit";
    }

    Console.WriteLine("Damage: " + damage + " (" + label + ")");
}


// ===== B2 =====
{
    int gold = 120;
    int choice = 2;

    string itemName = "";
    int price = 0;

    switch (choice)
    {
        case 1:
            itemName = "Sword";
            price = 100;
            break;
        case 2:
            itemName = "Bow";
            price = 80;
            break;
        case 3:
            itemName = "Potion";
            price = 25;
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    if (price > 0)
    {
        if (gold >= price)
        {
            gold = gold - price;
            Console.WriteLine("You bought a " + itemName + "! Gold left: " + gold);
        }
        else
        {
            int needed = price - gold;
            Console.WriteLine("Not enough gold! You need " + needed + " more gold.");
        }
    }
}


// ===== B3 =====
{
    for (int i = 1; i <= 30; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("Wave " + i + ": BOSS");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Wave " + i + ": Slime");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Wave " + i + ": Bat");
        }
        else
        {
            Console.WriteLine("Wave " + i + ": empty");
        }
    }
}


// ===== B4 =====
{
    int level = 1;
    int xp = 0;
    int fights = 0;

    while (level < 5)
    {
        fights++;
        xp = xp + 35;

        if (xp >= 100)
        {
            xp = xp - 100;
            level++;
            Console.WriteLine("LEVEL UP! Now level " + level);
        }
    }

    Console.WriteLine("Reached level " + level + " after " + fights + " fights (xp left: " + xp + ")");
}


// ===== B5 =====
{
    int Clamp(int value, int min, int max)
    {
        if (value < min)
        {
            return min;
        }
        else if (value > max)
        {
            return max;
        }
        else
        {
            return value;
        }
    }

    Console.WriteLine(Clamp(150, 0, 100));
    Console.WriteLine(Clamp(-20, 0, 100));
    Console.WriteLine(Clamp(55, 0, 100));

    int hp = 80;
    hp = Clamp(hp + 50, 0, 100);
    Console.WriteLine("HP after potion: " + hp);
}


// ===== B6 =====
{
    string GetRank(int score)
    {
        if (score >= 1000)
        {
            return "Gold";
        }
        else if (score >= 500)
        {
            return "Silver";
        }
        else if (score >= 1)
        {
            return "Bronze";
        }
        else
        {
            return "No medal";
        }
    }

    for (int score = 0; score <= 1250; score += 250)
    {
        Console.WriteLine("Score " + score + ": " + GetRank(score));
    }
}


// ===== B7 =====
{
    int Attack(int hp, int damage)
    {
        hp = hp - damage;
        if (hp < 0)
        {
            hp = 0;
        }
        return hp;
    }

    bool IsAlive(int hp)
    {
        if (hp > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    int playerHp = 150;
    int bossHp = 120;
    int turn = 0;

    while (IsAlive(playerHp) && IsAlive(bossHp))
    {
        turn++;

        bossHp = Attack(bossHp, 25);

        if (!IsAlive(bossHp))
        {
            Console.WriteLine("Turn " + turn + " | Boss: " + bossHp);
            break;
        }

        int bossDamage = 25;
        if (turn % 3 == 0)
        {
            bossDamage = 50;
        }

        playerHp = Attack(playerHp, bossDamage);

        Console.WriteLine("Turn " + turn + " | Boss: " + bossHp + " | Player: " + playerHp);
    }

    if (IsAlive(playerHp))
    {
        Console.WriteLine("You win in " + turn + " turns! HP left: " + playerHp);
    }
    else
    {
        Console.WriteLine("You lose in " + turn + " turns! Boss HP left: " + bossHp);
    }
}


// ===== B8 =====
{
    string Hint(int guess, int secret)
    {
        if (guess < secret)
        {
            return "Too low";
        }
        else if (guess > secret)
        {
            return "Too high";
        }
        else
        {
            return "Correct!";
        }
    }

    int secret = new Random().Next(1, 101);
    int triesLeft = 5;
    int triesUsed = 0;
    int guess = 0;

    while (triesLeft > 0 && guess != secret)
    {
        Console.Write("Guess (" + triesLeft + " tries left): ");
        guess = int.Parse(Console.ReadLine());

        triesLeft--;
        triesUsed++;

        string hint = Hint(guess, secret);
        Console.WriteLine(hint);
    }

    if (guess == secret)
    {
        Console.WriteLine("You found it in " + triesUsed + " tries!");
    }
    else
    {
        Console.WriteLine("You lost! The secret number was " + secret);
    }
}