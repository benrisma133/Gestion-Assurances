using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Controls
{
    public partial class ctrlComboBox : UserControl
    {

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
            get { return _fieldValue; }
            set
            {
                _fieldValue = value;
                cbValue.Text = _fieldValue;
            }
        }

        Image _fieldIcon;
        public Image FieldIcon
        {
            get { return _fieldIcon; }
            set
            {
                _fieldIcon = value;
                pbIcon.Image = _fieldIcon;
            }
        }

        bool _isVisibleIconAccept;
        public bool IsVisibleIconAccept
        {
            get { return _isVisibleIconAccept; }
            set
            {
                _isVisibleIconAccept = value;
                pbIconAccept.Visible = _isVisibleIconAccept;
            }
        }

        public ctrlComboBox()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.ComboBox MyComboBox
        {
            get { return cbValue; }
        }

        public event EventHandler ComboBoxItemChanged
        {
            add { cbValue.SelectedIndexChanged += value; }
            remove { cbValue.SelectedIndexChanged -= value; }
        }

        // Optional: Custom event for SelectedValueChanged
        public event EventHandler ComboBoxValueChanged
        {
            add { cbValue.SelectedValueChanged += value; }
            remove { cbValue.SelectedValueChanged -= value; }
        }

        public event EventHandler ComboBoxSelectedIndexChanged
        {
            add { cbValue.SelectedIndexChanged += value; }
            remove { cbValue.SelectedIndexChanged -= value; }
        }



    }
}
