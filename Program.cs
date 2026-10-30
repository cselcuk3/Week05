using System;

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