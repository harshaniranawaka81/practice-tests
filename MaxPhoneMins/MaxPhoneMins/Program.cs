// See https://aka.ms/new-console-template for more information

int min1 = 1, min2_10 = 2, min11 = 1, s = 6;

int mins = 0;

int remaining = s;

if (remaining >= min1 * 1)
{
    remaining -= min1 * 1;
    mins++;
}

int min2 = 0;
if (remaining >= min2_10 * 9)
{
    remaining -= min2_10 * 9;
    mins += 9;
}
else
{
    min2 = remaining / min2_10;
    remaining -= min2_10 * min2;
    mins += min2;
}

int other = 0;
if (remaining > min11 * 1)
{
    other = remaining / min11;
    remaining -= min11 * other;
    mins += other;
}

return mins;