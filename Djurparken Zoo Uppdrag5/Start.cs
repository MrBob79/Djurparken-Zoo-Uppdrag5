namespace Djurparken_Zoo_Uppdrag5
{
    public partial class Start : Form
    {

       
        public Start()
        {
            InitializeComponent();
            OpeningTime(); // skriver ut öppettider
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
            txtOpeningTime.Text = "Måndag - Fredag 10-19\r\n" + "Lördagar 12-18\r\n" + "Söndagar stängt";
        }

        public void TicketPrice()
        {
            txtTicket.Text = "Vuxen 195kr\r\n" + "Barn mellan 4 och 12 år 99kr\r\n" + "Barn under 4år går in gratis\r\n" + "Barn över 12 år räknas som vuxen!";
        }
    }
}
