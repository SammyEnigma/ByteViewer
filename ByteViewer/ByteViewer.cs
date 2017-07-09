#define TESTING
using System.Windows.Forms;

namespace ByteVieer
{
    public partial class ByteViewer : UserControl
    {
        public enum DisplayFormat
        {
            Binary = 2,
            Hexadecimal = 16,
            Decimal = 10
        }

        public const short DEFAULT_COLUMN_WIDTH = 8;
        public const short DEFAULT_COLUMNS = 2;

        private byte[] _data;

        public byte[] Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }

        public bool HasData => null != _data;

        /// <summary>
        /// Set the number of columns to display.
        /// Each column is width of <see cref="ColumnWidth"/>
        /// </summary>
        public short Columns = DEFAULT_COLUMNS;

        /// <summary>
        /// The number of bytes in one column
        /// </summary>
        public short ColumnWidth = DEFAULT_COLUMN_WIDTH;

        /// <summary>
        /// If spacing must be added between columns
        /// </summary>
        public bool ColumnSpacing = true;

        public DisplayFormat Format = DisplayFormat.Hexadecimal;

        public ByteViewer()
        {

#if TESTING
            _data = new byte[]{
210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77,210, 64, 61, 97, 97, 125, 57, 202, 69, 180, 158, 227, 72, 72, 118, 67,
214, 230, 60, 187, 69, 59, 227, 166, 149, 231, 230, 50, 39, 4, 51, 67,
4, 208, 35, 157, 169, 16, 92, 77
            };
#endif

            InitializeComponent();
            lineTextbox.SelectionAlignment = HorizontalAlignment.Right;

            Fill();
        }

        private void Fill()
        {
            lengthTextbox.Text = $"{_data.Length} bytes";
            if ((null != _data) && (_data.Length > 0))
            {
                ByteWriter.Builder builder = new ByteWriter.Builder();
                builder.SetColSpacing(ColumnSpacing);
                builder.SetColWidth(ColumnWidth);
                builder.SetColumnCount(Columns);
                builder.SetDisplayFormat(Format);

                ByteWriter writer = builder.Build();

                ByteWriter.RichTextboxes tBox = new ByteWriter.RichTextboxes()
                {
                    dataTextbox = dataTextbox,
                    lineTextbox = lineTextbox,
                    asciiTextBox = asciiTextbox,
                    columnTextbox = columnTextBox
                };

                writer.Write(_data, tBox);
            }
        }

        private void dataTextBox_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dataTextbox_VScroll(object sender, System.EventArgs e)
        {
            int verticalPos
                = TextBoxUtils.GetScrollPos(dataTextbox.Handle, (int)TextBoxUtils.ScrollType.VERTICAL);

            verticalPos <<= 16;

            uint scrollParameter = TextBoxUtils.SB_THUMB_POS | (uint)verticalPos;

            TextBoxUtils.SendMessage(lineTextbox.Handle, TextBoxUtils.WM_VSCROLL, new System.IntPtr(scrollParameter), new System.IntPtr(0));
            TextBoxUtils.SendMessage(asciiTextbox.Handle, TextBoxUtils.WM_VSCROLL, new System.IntPtr(scrollParameter), new System.IntPtr(0));

        }

        private void dataTextbox_HScroll(object sender, System.EventArgs e)
        {
            int horizontalPos
                = TextBoxUtils.GetScrollPos(dataTextbox.Handle, (int)TextBoxUtils.ScrollType.HORIZONTAL);

            horizontalPos <<= 16;

            uint scrollParameter = TextBoxUtils.SB_THUMB_POS | (uint)horizontalPos;

            TextBoxUtils.SendMessage(columnTextBox.Handle, TextBoxUtils.WM_HSCROLL, new System.IntPtr(scrollParameter), new System.IntPtr(0));
            TextBoxUtils.SendMessage(asciiTextbox.Handle, TextBoxUtils.WM_HSCROLL, new System.IntPtr(scrollParameter), new System.IntPtr(0));
        }

        private void lengthTextbox_Click(object sender, System.EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
