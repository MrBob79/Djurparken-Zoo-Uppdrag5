using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Djurparken_Zoo_Uppdrag5
{
    public partial class Admin : Form
    {
        private Start startForm;

        public Admin(Start startForm)
        {
            InitializeComponent();
            this.startForm = startForm;
        }

        private void btnTempHour(object sender, EventArgs e)
        {
            string textToSend = txtBoxAdmin.Text; // Skickar indata till startsida för öppettider
            startForm.UpdateOpening(textToSend);
        }

        private void btnTempPrice(object sender, EventArgs e)
        {
            string textToSend = txtBoxPrice.Text; // Skickar indata till startsida för biljettpriser
            startForm.UpdatePrice(textToSend);
        }

        private void btnStatics_Click(object sender, EventArgs e)
        {

        }
    }
}
