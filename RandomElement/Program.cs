string[] snacks = { "sushi", "pizza", "burger", "chiken wings", "asian takeaway" };

Random rnd = new Random();

int randomTindex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomTindex]}");
