public class Hand
{
        public Finger[] fingers;

        public Hand()
        {
            fingers = new Finger[4];
            for (int i = 0; i < 4; i++)
            {
                fingers[i] = new Finger();
            }
        }

        public void BendFingers()
        {
            foreach (Finger finger in fingers)
            {
                finger.Bend();
            }
        }
    }

