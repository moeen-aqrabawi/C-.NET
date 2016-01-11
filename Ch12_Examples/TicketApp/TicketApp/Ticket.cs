using System;

namespace TicketApp
{
    class Ticket
    {
        private const
            decimal COST_PER_5_OVER = 87.50M;
        private int speedLimit;
        private int speed;
        private decimal fine;

        public Ticket()
        {

        }

        public Ticket(int speedLmt,
                        int reportedSpeed)
        {

            speedLimit = speedLmt;
            speed = reportedSpeed - speedLimit;
        }

        public decimal Fine
        {
            get
            {
                return fine;
            }
        }

        public void SetFine(char classif)
        {
            fine = (speed / 5 * COST_PER_5_OVER)
                        + 75.00M;
            if (classif == '4')
                if (speed > 20)
                    fine += 200;
                else
                    fine += 50;
            else
                if (classif == '1')
                    if (speed < 21)
                        fine -= 50;
                    else
                        fine += 100;
                else
                    if (speed > 20)
                        fine += 100;
        }

    }
}
