using System.Windows.Controls;

namespace System.Drawing
{
    internal class Size : TextBox
    {
        private int v1;
        private int v2;

        public Size(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}