using System.Windows.Forms;
using Copy_to_Clipboard.Properties;

namespace Copy_to_Clipboard
{
    public partial class Copy2Clipboard : Form
    {
        public Copy2Clipboard()
        {
            InitializeComponent();
        }

        private void Copy2Clipboard_Load(object sender, System.EventArgs e)
        {
            Clipboard.SetText(Settings.Default.Text);
            Close();
        }
    }
}
