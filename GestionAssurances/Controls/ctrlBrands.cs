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
    public partial class ctrlBrands : UserControl
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
            get { return lblValue.Text; }
            set
            {
                _fieldValue = value;
                lblValue.Text = _fieldValue;
            }
        }
        public Color BackgroundColor
        {
            get { return lblValue.BackColor; }
            set { lblValue.BackColor = value; }
        }


        Color _fieldValueColor;
        public Color FieldValueColor
        {
            get { return lblValue.ForeColor; }
            set
            {
                _fieldValueColor = value;
                lblValue.ForeColor = _fieldValueColor;
            }
        }

        Color _fieldNameColor;
        public Color FieldNameColor
        {
            get { return lblName.ForeColor; }
            set
            {
                _fieldNameColor = value;
                lblName.ForeColor = _fieldNameColor;
            }
        }
        public ctrlBrands()
        {
            InitializeComponent();
        }
    }
}
