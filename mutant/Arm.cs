public class Arm
{
    public Hand[] hands;

    public Arm()
    {
        hands = new Hand[2];
        for (int i = 0; i < 2; i++)
        {
            hands[i] = new Hand();
        }
    }

}
