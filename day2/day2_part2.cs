using (var sr = new StreamReader("day2_input.txt"))
{
    int total = 0;
    string line;

    //foreach (string line in test)
    while ((line = sr.ReadLine()) != null)
    {
        int maxRed = 0, maxGreen = 0, maxBlue = 0;
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

            if (red > maxRed) { maxRed = red; }
            if (green > maxGreen) {  maxGreen = green; }
            if (blue > maxBlue) {  maxBlue = blue; }
        }

        int idx_space = line.IndexOf(' ');
        int aaa = maxRed * maxGreen * maxBlue;
        Console.WriteLine("Game " + line.Substring(idx_space + 1, line.IndexOf(':') - idx_space - 1) + " power: " + aaa);
        total += aaa;
    }

    Console.WriteLine("Total: " + total.ToString());
}
