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
    public partial class ctrlTextBox : UserControl
    {

        public class ValidationEventArgs : EventArgs
        {
            public string Text { get; set; }
            public string ErrorMessage { get; set; }
            public ValidationEventArgs(string text)
            {
                Text = text;
            }
        }

        public event EventHandler<ValidationEventArgs> ValidatingTextChanged;


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
            get { return txtValue.Text; }
            set
            {
                _fieldValue = value;
                txtValue.Text = _fieldValue;
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

        Image _fieldIconAccept;
        public Image FieldIconAccept
        {
            get { return _fieldIconAccept; }
            set
            {
                _fieldIconAccept = value;
                pbIconAccept.Image = _fieldIconAccept;
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

        public ctrlTextBox()
        {
            InitializeComponent();
        }

        private void txtValue_Validating(object sender, CancelEventArgs e)
        {
            var args = new ValidationEventArgs(FieldValue);

            ValidatingTextChanged?.Invoke(this, args);
        }
    }
}
