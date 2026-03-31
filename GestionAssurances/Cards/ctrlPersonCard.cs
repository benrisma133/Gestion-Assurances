using GA_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Cards
{
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonData(clsPerson person)
        {
            lblFirstName.FieldValue = person.FirstName;
            lblLastName.FieldValue = person.LastName;
            lblEmail.FieldValue = person.Email;
            lblPhone.FieldValue = person.Phone;
            if (!string.IsNullOrEmpty(person.Address))
                lblAddress.FieldValue = person.Address;
            else
                lblAddress.FieldValue = "N/A";
            lblCreatedAt.FieldValue = person.CreatedAt.ToString("yyyy-MM-dd");
        }

    }
}
