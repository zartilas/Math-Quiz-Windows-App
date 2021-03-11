using System.Windows.Forms;

namespace FinalErgasia2.Classes
{
    class MsgBox
    {
        public MsgBox()
        {
        }

        public void Msg()
        {
            MessageBox.Show("You have reached the maximum number of helps!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
