using (var sr = new StreamReader("day2_input.txt"))
{
    int total = 0;
    string line;

    //foreach (string line in test)
    while ((line = sr.ReadLine()) != null)
    {
        bool santa = true;
        string mess = line.Substring(line.IndexOf(':') + 1);
        string[] rocks = mess.Split(';');
        foreach (string rock in rocks)
        {
            int red = 0, green = 0, blue = 0;
            string[] actualRocks = rock.Split(",");

            foreach(string actualRock in actualRocks)
            {
                string trimmedRock = actualRock.Trim();
                if (trimmedRock.Contains("red"))
                {
                    red += Convert.ToInt32(trimmedRock.Substring(0, trimmedRock.IndexOf(' ')));
                }
                else if (trimmedRock.Contains("green"))
                {
                    green += Convert.ToInt32(trimmedRock.Substring(0, trimmedRock.IndexOf(' ')));
                }
                else if (trimmedRock.Contains("blue"))
                {
                    blue += Convert.ToInt32(trimmedRock.Substring(0, trimmedRock.IndexOf(' ')));
                }
            }

            if (red > 12 || blue > 14 || green > 13)
            {
                santa = false;
            }
        }

        if (santa)
        {
            int idx_space = line.IndexOf(' ');
            Console.WriteLine(line.Substring(idx_space + 1, line.IndexOf(':') - idx_space - 1));
            total += Convert.ToInt32(line.Substring(idx_space + 1, line.IndexOf(':') - idx_space - 1));
        }
    }

    Console.WriteLine("Total: " + total.ToString());
}
