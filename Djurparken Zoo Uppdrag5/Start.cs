namespace Djurparken_Zoo_Uppdrag5
{
    public partial class Start : Form
    {

       
        public Start()
        {
            InitializeComponent();
            OpeningTime(); // skriver ut �ppettider
            TicketPrice(); // skriver ut biljettpriser
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            Visitor form2 = new Visitor();
            form2.Show();
        }

        private void btnKeeper_Click(object sender, EventArgs e)
        {
            Keeper form3 = new Keeper();
            form3.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin form4 = new Admin(this);
            form4.Show();
        }

        public void UpdateOpening(string text)
        {
            txtOpeningTime.Text = text;
        }

        public void UpdatePrice(string text)
        {
            txtTicket.Text = text;
        }
        public void OpeningTime()
        {
            txtOpeningTime.Text = "M�ndag - Fredag 10-19\r\n" + "L�rdagar 12-18\r\n" + "S�ndagar st�ngt";
        }

        public void TicketPrice()
        {
            txtTicket.Text = "Vuxen 195kr\r\n" + "Barn mellan 4 och 12 �r 99kr\r\n" + "Barn under 4�r g�r in gratis\r\n" + "Barn �ver 12 �r r�knas som vuxen!";
        }
    }
}
