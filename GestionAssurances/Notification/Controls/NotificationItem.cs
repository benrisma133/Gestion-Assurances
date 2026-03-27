using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAssurances.Notification.Controls
{
    public partial class NotificationItem : UserControl
    {
        // ---- Properties ---- //
        public string NotificationID { get; set; }

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string Details
        {
            get => lblDetails.Text;
            set => lblDetails.Text = value;
        }

        public string Date
        {
            get => lblDate.Text;
            set => lblDate.Text = value;
        }

        public Image Icon
        {
            get => picIcon.Image;
            set => picIcon.Image = value;
        }

        // ------------------- Border Color Property ------------------
        private Color _borderColor = Color.FromArgb(66, 133, 244); // default blue
        [Category("Appearance")]
        [Description("Gets or sets the border color of the left panel.")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                gunaPanel1.BackColor = value;
            }
        }

        // ------------------- Animation / Hover ------------------
        private Color normalBackColor = Color.FromArgb(220, 255, 240); // sweet background
        private Color hoverBackColor = Color.FromArgb(250, 255, 250); // tiny hint of green


        public bool isSelected { get; set; } = false;
        private bool isHovered = false;

        // Animation variables
        private Timer uiAnimTimer;
        private float animProgress = 0f;
        private const float animSpeed = 0.08f; // Increase → faster animation

        private Color startBackColor;
        private Color endBackColor;

        private Color startBorderColor;
        private Color endBorderColor;

        private Color clickFlashColor = Color.FromArgb(180, 220, 250); // light blue flash
        private bool isClicking = false;

        public bool IsRead { get; set; } = false;


        public NotificationItem()
        {
            InitializeComponent();

            // Click events
            this.Click += NotificationItem_Click;
            lblTitle.Click += NotificationItem_Click;
            lblDate.Click += NotificationItem_Click;
            picIcon.Click += NotificationItem_Click;

            // Hover events
            this.MouseEnter += HoverOn;
            this.MouseLeave += HoverOff;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseEnter += HoverOn;
                ctrl.MouseLeave += HoverOff;
                ctrl.Click += NotificationItem_Click;
            }

            this.BackColor = normalBackColor;

            // UI Animation Timer
            uiAnimTimer = new Timer();
            uiAnimTimer.Interval = 15;
            uiAnimTimer.Tick += UiAnimTimer_Tick;
        }

        // ------------------- Events ------------------
        public event EventHandler OnNotificationClick;

        private async void NotificationItem_Click(object sender, EventArgs e)
        {
            isSelected = true; // stays selected only when clicked

            // Flash effect
            isClicking = true;
            Color original = this.BackColor;
            this.BackColor = clickFlashColor;
            await Task.Delay(150); // flash duration 150ms
            this.BackColor = original;
            isClicking = false;

            UpdateBackground();
            OnNotificationClick?.Invoke(this, e);
        }

        private void HoverOn(object sender, EventArgs e)
        {
            isHovered = true;
            UpdateBackground();
        }

        private void HoverOff(object sender, EventArgs e)
        {
            isHovered = false;

            if (!IsRead)
                isSelected = false;  // *** ADD THIS LINE ***

            UpdateBackground();
        }


        // ------------------- Animation Logic ------------------
        public void UpdateBackground()
        {
            // ---------------- BACKGROUND LOGIC ----------------
            if (isSelected)
            {
                endBackColor = Color.FromArgb(250, 255, 250); // very light blue selected background
            }
            else if (isHovered)
            {
                endBackColor = hoverBackColor; // hover works even if read
            }
            else if (IsRead)
            {
                endBackColor = Color.WhiteSmoke; // normal read background
            }
            else
            {
                endBackColor = normalBackColor; // normal background
            }

            // ---------------- BORDER LOGIC ----------------
            Color selectedBorderColor = Color.FromArgb(66, 133, 244); // your theme color

            if (isSelected)
            {
                endBorderColor = selectedBorderColor; // always show selected border
            }
            else if (isHovered)
            {
                endBorderColor = selectedBorderColor; // hover border works
            }
            else if (IsRead)
            {
                endBorderColor = Color.Transparent; // read items without hover
            }
            else
            {
                endBorderColor = Color.FromArgb(40, 205, 140); // normal green
            }

            // 💥 Stop any previous animation before starting a new one
            uiAnimTimer.Stop();

            // reset animation start values
            startBackColor = this.BackColor;
            startBorderColor = _borderColor;

            animProgress = 0f;
            uiAnimTimer.Start();
        }

        private void UiAnimTimer_Tick(object sender, EventArgs e)
        {
            animProgress += animSpeed;
            if (animProgress >= 1f)
            {
                animProgress = 1f;
                uiAnimTimer.Stop();
            }

            float t = EaseInOut(animProgress);

            // Animate Background
            this.BackColor = LerpColor(startBackColor, endBackColor, t);

            // Animate Border
            _borderColor = LerpColor(startBorderColor, endBorderColor, t);
            gunaPanel1.BackColor = _borderColor;
        }

        private Color LerpColor(Color a, Color b, float t)
        {
            int r = (int)(a.R + (b.R - a.R) * t);
            int g = (int)(a.G + (b.G - a.G) * t);
            int b2 = (int)(a.B + (b.B - a.B) * t);
            return Color.FromArgb(r, g, b2);
        }

        private float EaseInOut(float x)
        {
            // Cubic smooth step
            return x * x * (3 - 2 * x);
        }
    }
}
