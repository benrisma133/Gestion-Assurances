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
    public partial class ctrlLbaelField2 : UserControl
    {

        private Color _borderColor = Color.FromArgb(66, 133, 244); // default blue

        [Category("Appearance")]
        [Description("Gets or sets the border color of the left panel.")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                gunaPanel1.BackColor = value; // apply to your docked left panel
            }
        }

        string _fieldName;
        public string FieldName
        {
            get { return _fieldName; }
            set
            {
                _fieldName = value;
                lblName.Text = _fieldName;
            }
        }

        string _fieldValue;
        public string FieldValue
        {
            get { return lblValue.Text; }
            set
            {
                _fieldValue = value;
                lblValue.Text = _fieldValue;
            }
        }
        public ctrlLbaelField2()
        {
            InitializeComponent();

            gunaPanel1.BackColor = _borderColor; // init default
        }
    }
}
