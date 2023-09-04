

public class Mutant
{
    public Arm[] arms;
    public Leg[] legs;

    public Mutant(int amountOfArms, int amountOfLegs)
    {
        arms = new Arm[amountOfArms];

        for (int i = 0; i < amountOfArms; i++)
        {
            arms[i] = new Arm();
        }
        legs = new Leg[amountOfLegs];

        for (int i = 0; i < amountOfLegs; i++)
        {
            legs[i] = new Leg();
        }
    }
    public void Move()
    {
        foreach (Leg leg in legs)
        {
            leg.Move(1, 1);
        }
    }
}

